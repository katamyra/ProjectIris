from PyPDF2 import PdfFileWriter, PdfFileReader
import io
from reportlab.pdfgen import canvas
from reportlab.lib.pagesizes import letter

name = "Krish Katariya"
packet = io.BytesIO()
can = canvas.Canvas(packet, pagesize=letter)
can.setFont('Helvetica', 22)
can.drawString(300, 300, name)
can.save()

#move to the beginning of the StringIO buffer
packet.seek(0)

# create a new PDF with Reportlab
new_pdf = PdfFileReader(packet)
# read your existing PDF
existing_pdf = PdfFileReader(open("C:\\Users\\krish\\Downloads\\Certificate.pdf", "rb"))
output = PdfFileWriter()
# add the "watermark" (which is the new pdf) on the existing page
page = existing_pdf.getPage(0)
page.mergePage(new_pdf.getPage(0))

# PAGE 2 VALUES NOW --------------------------------
scores = [["Score1", "MScore1"], ["Score2", "MScore 2"], ["Score3", "MScore 3"], ["Score4", "MScore 4"]]
packet2 = io.BytesIO()
can2 = canvas.Canvas(packet2, pagesize=letter)
can2.setFont('Helvetica', 14)
can2.drawString(153, 396, scores[0][0])
can2.drawString(264, 396, scores[0][1])
can2.drawString(530, 396, scores[1][0])
can2.drawString(650, 396, scores[1][1])
can2.drawString(153, 196, scores[2][0])
can2.drawString(264, 196, scores[2][1])
can2.drawString(530, 196, scores[3][0])
can2.drawString(650, 196, scores[3][1])
can2.save()
#packet2.seek(0) #??


new_pdf2 = PdfFileReader(packet2)
page2 = existing_pdf.getPage(1)
page2.mergePage(new_pdf2.getPage(0))


#OUTPUT ----------------------------------

output.addPage(page)
output.addPage(page2)
# finally, write "output" to a real file
outputStream = open("C:\\Users\\krish\\Downloads\\CertificateNew.pdf", "wb")
output.write(outputStream)
outputStream.close()
