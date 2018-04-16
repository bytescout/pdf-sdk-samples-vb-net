'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to change the word spacing.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument = New Document()
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"
        ' Add page
        Dim page = New Page(PaperFormat.A4)
        pdfDocument.Pages.Add(page)

        Dim canvas = page.Canvas

        Dim font = New Font("Arial", 16)
        Dim brush = New SolidBrush()
        Dim stringFormat = New StringFormat()

        ' Standard word spacing
        stringFormat.WordSpacing = 0.0F
        canvas.DrawString("Standard word spacing 0.0", font, brush, 20, 20, stringFormat)

        ' Increased word spacing
        stringFormat.WordSpacing = 5.0F
        canvas.DrawString("Increased word spacing 5.0", font, brush, 20, 50, stringFormat)

        ' Reduced word spacing
        stringFormat.WordSpacing = -2.5F
        canvas.DrawString("Reduced word spacing -2.5", font, brush, 20, 80, stringFormat)


        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
