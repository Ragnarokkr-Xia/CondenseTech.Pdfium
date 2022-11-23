# PdfiumNet
Modified [PdfiumViewer](https://github.com/pvginkel/PdfiumViewer), adapted .Net Standard 2.1/.Net 5.0/.Net 6.0.
## Primary modifications:
+ **REMOVED** all WinForm related codes
+ Substituted `GDI+` with `SKIA`
+ Minor modifications on rendering API, the code should explain itself
+ Compatiable with the original version of Pdfium from Google and the modified version which hava an export of `AddInitializationCount`
