﻿Imports System.Drawing.Printing
Imports Bytescout.PDF.Converters

Module Module1

    Sub Main()

		Using converter As New DocxToPdfConverter()

			converter.PageSize = PaperKind.A4
			converter.Orientation = PaperOrientation.Portrait
			converter.Footer = "<p style=""color: blue;"">FOOTER TEXT</p>"

			converter.ConvertDocxToPdf("sample.docx", "result.pdf")

		End Using

		' Open result file in default PDF viewer
		Process.Start("result.pdf")

    End Sub

End Module
