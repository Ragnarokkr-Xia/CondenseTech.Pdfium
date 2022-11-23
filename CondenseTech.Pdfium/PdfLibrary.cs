using System;
using System.Threading;

namespace CondenseTech.Pdfium
{
    internal class PdfLibrary : IDisposable
    {
        private static readonly AutoResetEvent SyncAutoResetEvent = new AutoResetEvent(true);
        private static PdfLibrary _library;

        public static void EnsureLoaded()
        {
            SyncAutoResetEvent.WaitOne();
            try
            {
                _library ??= new PdfLibrary();
            }
            finally
            {
                SyncAutoResetEvent.Set();
            }
        }

        private bool _disposed;

        private PdfLibrary()
        {
            NativeMethods.FPDF_InitLibrary();
        }

        ~PdfLibrary()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                NativeMethods.FPDF_DestroyLibrary();
                _disposed = true;
            }
        }
    }
}
