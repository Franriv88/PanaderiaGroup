using iText.IO.Font;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Transitions;


namespace Proyecto_Panadería
{
    public partial class BillingView : Form
    {
        //Ruta para guardar archivo
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DocumentosPDF\";
        public BillingView()
        {
            InitializeComponent();
        }
         
        public void billingConfirmButton(object sender, EventArgs e)
        {
            iconTransition();
            crearPDF();
        }
        public void crearPDF()
        {

            var exportaPDF = Path.Combine(path, "Documento.pdf");
            using (var writer = new PdfWriter(exportaPDF))
            {

                using (var pdf = new PdfDocument(writer))
                {
                    var doc = new Document(pdf, iText.Kernel.Geom.PageSize.A4);

                    //margenes de pdf
                    doc.SetMargins(50, 0, 0, 0);

                    // Cargar imagen desde el disco
                    ImageData imageData = ImageDataFactory.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DocumentosPDF\LaCentral.png");

                    //Creo la imagen y defino los parametros
                    var image = new iText.Layout.Element.Image(imageData)

                       .SetTextAlignment(TextAlignment.CENTER)
                       .SetFixedPosition(1, 10, 750) //(N° de hojas, izquierda, abajo) Obs: el nro de hojas podríamos establecerlo para que sume
                                                     //una hora cada 7-10 productos
                       ;

                    doc.Add(image);

                    Paragraph encabezado = new Paragraph("");
                    encabezado.Add(image);
                    doc.Add(encabezado);



                    //defino el nombre de la empresa
                    string nombreEmpresa = "La Continental";
                    string sitioweb = "www.lacontinental.com";
                    //string nombreSucursal = "Sucursal 1";
                    string direccionSucursal = "Centro 310";
                    string nombreVendedor = "Pedro P.";

                    PdfFont boldFont = PdfFontFactory.CreateFont("C:/Windows/Fonts/arialbd.ttf", PdfEncodings.IDENTITY_H);
                    // PdfFont boldFont = PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD);
                    iText.Kernel.Colors.Color colorOrange = new DeviceRgb(255, 80, 0);
                    iText.Kernel.Colors.Color colorAzul = new DeviceRgb(0, 92, 226);
                    iText.Kernel.Colors.Color colorWhite = new DeviceRgb(255, 255, 255);
                    iText.Kernel.Colors.Color colorNegro = new DeviceRgb(0, 0, 0);


                    Paragraph parrafo0 =
                       new Paragraph("FACTURA ELECTRÓNICA")
                                .SetFontSize(32)
                                .SetMargins(50, 10, 0, 0)
                                .SetFontColor(colorOrange)
                                .SetFont(boldFont)
                                .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER)
                                .SetTextAlignment(TextAlignment.CENTER);


                    doc.Add(parrafo0);

                    //FOLIO
                    Paragraph pFolio = new Paragraph("");
                    pFolio.Add("FACTURA: 100");
                    pFolio.SetFixedPosition(250, 800, 400); //left, bot, width
                    pFolio.SetPageNumber(1);
                    pFolio.SetFont(boldFont);
                    pFolio.SetTextAlignment(TextAlignment.CENTER);
                    pFolio.SetFontSize(18);
                    pFolio.SetFontColor(colorAzul);
                    doc.Add(pFolio);

                    Paragraph pTel = new Paragraph("TELÉFONO: \n" + "018000000");
                    pTel.SetFixedPosition(250, 600, 300);
                    pTel.SetPageNumber(1);
                    pTel.SetFont(boldFont);
                    pTel.SetTextAlignment(TextAlignment.CENTER);
                    pTel.SetFontSize(24);
                    pTel.SetFontColor(colorAzul);
                    doc.Add(pTel);

                    Paragraph parrafo1 =
                        new Paragraph("FECHA CREACIÓN: " + DateTime.Now + "\n").SetFontSize(12)

                                 .Add("\n" + nombreEmpresa + " \n").SetFontSize(12)
                                 //.Add("SUCURSAL: " + nombreSucursal + " \n").SetFontSize(12)
                                 .Add("DIRECCIÓN: " + direccionSucursal + "\n").SetFontSize(12)
                                 .SetMargins(0, 20, 0, 20)
                                 .Add("VENDEDOR: " + nombreVendedor + "\n")
                                 .Add("\nEstimado(a) " + clientNameInputText.Text.ToString() + " en atención a su solicitud, me permito enviarle la cotización correspondiente a los productos y servicios de su interes");


                    doc.Add(parrafo1).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

                    Style styleHeader = new Style()
                        .SetBackgroundColor(colorOrange)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(10);


                    //original 125,230,40,65,75

                    //nueva    90 , 210
                    Table table = new Table(new float[] { 100, 210, 40, 65, 55, 75 }, true);
                    table.SetMargins(0, 20, 0, 20);
                    table.SetBorder(iText.Layout.Borders.Border.NO_BORDER);

                    Cell cell = getCell("SKU", TextAlignment.CENTER);
                    cell.AddStyle(styleHeader);
                    /*
                    Cell cell = new Cell();
                    cell.AddStyle(styleHeader);
                    cell.Add("SKU");

                    Cell cell2 = new Cell();
                    cell2.AddStyle(styleHeader);
                    cell2.Add("DESCRIPCIÓN");

                    Cell cell3 = new Cell();
                    cell3.AddStyle(styleHeader);
                    cell3.Add("CANT");

                    Cell cell4 = new Cell();
                    cell4.AddStyle(styleHeader);
                    cell4.Add("PRECIO");

                    Cell cell5 = new Cell();
                    cell5.AddStyle(styleHeader);
                    cell5.Add("DESC");

                    Cell cell6 = new Cell();
                    cell6.AddStyle(styleHeader);
                    cell6.Add("TOTAL LINEA");

                    table.AddHeaderCell(cell);
                    table.AddHeaderCell(cell2);
                    table.AddHeaderCell(cell3);
                    table.AddHeaderCell(cell4);
                    table.AddHeaderCell(cell5);
                    table.AddHeaderCell(cell6);
                    */

                    doc.Add(table);

                    Paragraph pDis = new Paragraph("");
                    pDis.Add(new Tab());
                    pDis.AddTabStops(new TabStop(1000, iText.Layout.Properties.TabAlignment.LEFT));
                    pDis.SetMargins(0, 20, 0, 20);
                    pDis.Add("* Si ud necesita factura A, deberá solicitarlo al antes de abonar en caja. \n");

                    doc.Add(pDis);


                    Paragraph pD = new Paragraph("");
                    pD.Add(new Tab());
                    pD.AddTabStops(new TabStop(1000, iText.Layout.Properties.TabAlignment.RIGHT));
                    pD.SetMargins(10, 20, 10, 20);

                    doc.Add(pD);

                    //calculo los espacios



                    Paragraph pI = new Paragraph();
                    pI.SetTextAlignment(TextAlignment.LEFT);
                    pI.SetMargins(0, 20, 0, 20);
                    pI.SetPaddingRight(20);
                    pI.Add("FORMA DE PAGO: 1 CUOTA                                                                                                           ");
                    doc.Add(pI);

                    Paragraph pIm = new Paragraph();
                    pIm.SetTextAlignment(TextAlignment.RIGHT);
                    pIm.SetMargins(300, 150, 0, 50);
                    pIm.SetPaddingRight(20);
                    pIm.Add("SUBTOTAL: $");
                    doc.Add(pIm);
                    //IMPUESTOS
                    //DESCUENTO

                    Paragraph pT = new Paragraph("");
                    pT.SetTextAlignment(TextAlignment.LEFT); //alineación de la palabra TOTAL
                    pT.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.RIGHT); //alineación del contenedor 
                    pT.SetMargins(10, 40, 0, 50); //up, right, x, x
                    pT.SetFontSize(18);
                    pT.SetWidth(200);
                    pT.SetFont(boldFont);
                    pT.SetBackgroundColor(colorOrange);
                    pT.SetFontColor(colorWhite);
                    pT.SetPaddingRight(10);
                    pT.Add("TOTAL:$");
                    doc.Add(pT);

                    Paragraph pPago = new Paragraph("");
                    pPago.Add("* Para cualquier consulta, no dude en contactarnos a nuestro Whatsapp  +54 9 11 9557 4674. \n");

                    pPago.SetFixedPosition(0, 0, 600);
                    pPago.SetPadding(20);
                    pPago.SetFontSize(18);
                    pPago.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                    pPago.SetBackgroundColor(colorAzul);

                    doc.Add(pPago);



                }

            }

            try
            {

                if (File.Exists(path + "COTIZACION_100.pdf"))
                {
                    Process.Start(path + "COTIZACION_100.pdf");// ABRO EL ARCHIVO 
                }

            }
            catch (FileNotFoundException a)
            {


            }

        }

        public Cell getCell(String text, TextAlignment alignment)
        {
            Cell cell = new Cell().Add(new Paragraph(text));

            cell.SetTextAlignment(alignment);
            //cell.SetBorder(iText.Layout.Borders.Border.NO_BORDER);
            //cell.SetWidth();
            return cell;
        }

     


        //Transición de icónos PDF-Check
        private void iconTransition()
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(10));
            t.add(pdfPictureBox, "Left", -300);
            t.add(okPictureBox, "Left", 389);
            t.run();
        }

        private void clientNameInputText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
