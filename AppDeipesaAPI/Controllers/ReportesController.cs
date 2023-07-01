using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace AppDeipesaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportesController : ControllerBase
    {
        private InventarioDeipesaContext _context;

        public ReportesController(InventarioDeipesaContext context)
        {
            _context = context;
        }

        [HttpGet("inventory/by-city/{cityId}")]
        public async Task<ActionResult<FileStream>> GetInventoryReportByLocation(long cityId)
        {
            var almacen = await _context.Almacens
                .Include(a => a.Ciudad)
                .Include(a => a.Inventarios)
                    .ThenInclude(inv => inv.IdMaterialNavigation)
                .Where(a => a.CiudadId == cityId)
                .AsNoTracking()
                .AsSplitQuery()
                .FirstOrDefaultAsync();

            if (almacen == null)
            {
                return NotFound();
            }

            var doc = Document.Create(container =>
            {
                container.Page(page =>
                {
                    static IContainer Block(IContainer container)
                    {
                        return container
                            .Border(1)
                            .Padding(5)
                            .ShowOnce();
                    }

                    page.Header()
                        .PaddingHorizontal(2, Unit.Centimetre)
                        .PaddingVertical(1, Unit.Centimetre)
                        .Row(row =>
                        {
                            row.Spacing(25);

                            row.ConstantItem(100)
                                .Image("Assets/Images/logo.png");

                            row.RelativeItem()
                                .Column(col =>
                                {
                                    col.Item()
                                        .Text($"Inventario de {almacen.Ciudad?.Name}")
                                        .Bold()
                                        .FontColor(Colors.Black)
                                        .FontSize(20);

                                    col.Item()
                                        .Text($"Fecha: {DateTime.Now:dd/MM/yyyy}");
                                });
                        });

                    page.Content()
                        .PaddingHorizontal(2, Unit.Centimetre)
                        .Column(col =>
                        {
                            if (almacen.Inventarios.Count == 0)
                            {
                                col.Item()
                                    .AlignCenter()
                                    .Text("No hay inventario para mostrar")
                                    .Bold()
                                    .FontColor(Colors.Grey.Darken1)
                                    .FontSize(20);

                                return;
                            }

                            col.Item()
                                .Table(table =>
                                {
                                    table.ColumnsDefinition(def =>
                                    {
                                        foreach (var n in Enumerable.Range(0, 5))
                                            def.RelativeColumn();
                                    });

                                    table.Header(header =>
                                    {
                                        var style = new TextStyle()
                                            .FontColor(Colors.Black)
                                            .FontSize(12)
                                            .Bold();

                                        header.Cell().Element(Block).Text("ID").Style(style);
                                        header.Cell().Element(Block).Text("Material").Style(style);
                                        header.Cell().Element(Block).Text("Tipo de inventario").Style(style);
                                        header.Cell().Element(Block).Text("Cantidad").Style(style);
                                        header.Cell().Element(Block).Text("Stock mínimo").Style(style);
                                    });

                                    foreach (var inv in almacen.Inventarios)
                                    {
                                        table.Cell()
                                            .Element(Block)
                                            .Text(inv.IdInventario);

                                        table.Cell()
                                            .Element(Block)
                                            .Text(inv.IdMaterialNavigation?.NombreMaterial);

                                        table.Cell()
                                            .Element(Block)
                                            .Text(inv.TipoInventario);

                                        table.Cell()
                                            .Element(Block)
                                            .AlignCenter()
                                            .Text(inv.Cantidad);

                                        table.Cell()
                                            .Element(Block)
                                            .AlignCenter()
                                            .Text(inv.StockMinimo);
                                    }
                                });
                        });

                    page.Footer()
                        .Padding(2, Unit.Centimetre)
                        .AlignRight()
                        .Text(text =>
                        {
                            text.DefaultTextStyle(style =>
                                style.FontSize(12)
                                     .FontColor(Colors.Grey.Darken1));

                            text.CurrentPageNumber();
                            text.Span(" / ");
                            text.TotalPages();
                        });
                });
            });

            byte[] pdfFile = doc.GeneratePdf();
            var ms = new MemoryStream(pdfFile);
            return new FileStreamResult(ms, "application/pdf");
        }
    }
}
