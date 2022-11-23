using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

#pragma warning disable 1591

namespace CondenseTech.Pdfium
{
    public static class NativeMethods
    {
        private static readonly AutoResetEvent LockEvent = new AutoResetEvent(true);


        public static void FPDF_InitLibrary()
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FPDF_InitLibrary();
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static void FPDF_DestroyLibrary()
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FPDF_DestroyLibrary();
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static IntPtr FPDF_LoadMemDocument(SafeHandle data_buf, int size, string password)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDF_LoadMemDocument(data_buf, size, password);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static IntPtr FPDF_LoadMemDocument(byte[] data_buf, int size, string password)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDF_LoadMemDocument(data_buf, size, password);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static void FPDF_CloseDocument(IntPtr document)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FPDF_CloseDocument(document);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static int FPDF_GetPageCount(IntPtr document)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDF_GetPageCount(document);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static uint FPDF_GetDocPermissions(IntPtr document)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDF_GetDocPermissions(document);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static IntPtr FPDFDOC_InitFormFillEnvironment(IntPtr document, FPDF_FORMFILLINFO formInfo)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFDOC_InitFormFillEnvironment(document, formInfo);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static void FPDF_SetFormFieldHighlightColor(IntPtr hHandle, int fieldType, uint color)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FPDF_SetFormFieldHighlightColor(hHandle, fieldType, color);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static void FPDF_SetFormFieldHighlightAlpha(IntPtr hHandle, byte alpha)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FPDF_SetFormFieldHighlightAlpha(hHandle, alpha);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static void FORM_DoDocumentJSAction(IntPtr hHandle)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FORM_DoDocumentJSAction(hHandle);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static void FORM_DoDocumentOpenAction(IntPtr hHandle)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FORM_DoDocumentOpenAction(hHandle);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static void FPDFDOC_ExitFormFillEnvironment(IntPtr hHandle)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FPDFDOC_ExitFormFillEnvironment(hHandle);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static void FORM_DoDocumentAAction(IntPtr hHandle, FPDFDOC_AACTION aaType)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FORM_DoDocumentAAction(hHandle, aaType);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static IntPtr FPDF_LoadPage(IntPtr document, int page_index)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDF_LoadPage(document, page_index);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static IntPtr FPDFText_LoadPage(IntPtr page)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFText_LoadPage(page);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static void FORM_OnAfterLoadPage(IntPtr page, IntPtr _form)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FORM_OnAfterLoadPage(page, _form);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static void FORM_DoPageAAction(IntPtr page, IntPtr _form, FPDFPAGE_AACTION fPDFPAGE_AACTION)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FORM_DoPageAAction(page, _form, fPDFPAGE_AACTION);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static double FPDF_GetPageWidth(IntPtr page)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDF_GetPageWidth(page);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static double FPDF_GetPageHeight(IntPtr page)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDF_GetPageHeight(page);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static void FORM_OnBeforeClosePage(IntPtr page, IntPtr _form)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FORM_OnBeforeClosePage(page, _form);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static void FPDFText_ClosePage(IntPtr text_page)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FPDFText_ClosePage(text_page);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static void FPDF_ClosePage(IntPtr page)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FPDF_ClosePage(page);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static void FPDF_RenderPage(IntPtr dc, IntPtr page, int start_x, int start_y, int size_x, int size_y, int rotate, FPDF flags)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FPDF_RenderPage(dc, page, start_x, start_y, size_x, size_y, rotate, flags);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static void FPDF_RenderPageBitmap(IntPtr bitmapHandle, IntPtr page, int start_x, int start_y, int size_x, int size_y, int rotate, FPDF flags)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FPDF_RenderPageBitmap(bitmapHandle, page, start_x, start_y, size_x, size_y, rotate, flags);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static int FPDF_GetPageSizeByIndex(IntPtr document, int page_index, out double width, out double height)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDF_GetPageSizeByIndex(document, page_index, out width, out height);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static IntPtr FPDFBitmap_Create(int width, int height, int alpha)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFBitmap_Create(width, height, alpha);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static IntPtr FPDFBitmap_CreateEx(int width, int height, int format, IntPtr first_scan, int stride)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFBitmap_CreateEx(width, height, format, first_scan, stride);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static void FPDFBitmap_FillRect(IntPtr bitmapHandle, int left, int top, int width, int height, uint color)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FPDFBitmap_FillRect(bitmapHandle, left, top, width, height, color);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static IntPtr FPDFBitmap_Destroy(IntPtr bitmapHandle)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFBitmap_Destroy(bitmapHandle);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static int FPDFBitmap_GetStride(IntPtr bitmapHandle)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFBitmap_GetStride(bitmapHandle);
            }
            finally
            {
                LockEvent.Set();
            }
        }
        public static IntPtr FPDFBitmap_GetBuffer(IntPtr bitmapHandle)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFBitmap_GetBuffer(bitmapHandle);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static IntPtr FPDFText_FindStart(IntPtr page, byte[] findWhat, FPDF_SEARCH_FLAGS flags, int start_index)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFText_FindStart(page, findWhat, flags, start_index);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static int FPDFText_GetSchResultIndex(IntPtr handle)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFText_GetSchResultIndex(handle);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static int FPDFText_GetSchCount(IntPtr handle)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFText_GetSchCount(handle);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static int FPDFText_GetText(IntPtr page, int start_index, int count, byte[] result)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFText_GetText(page, start_index, count, result);

            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static void FPDFText_GetCharBox(IntPtr page, int index, out double left, out double right, out double bottom, out double top)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FPDFText_GetCharBox(page, index, out left, out right, out bottom, out top);

            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static int FPDFText_CountChars(IntPtr page)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFText_CountChars(page);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static bool FPDFText_FindNext(IntPtr handle)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFText_FindNext(handle);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static void FPDFText_FindClose(IntPtr handle)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FPDFText_FindClose(handle);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static bool FPDFLink_Enumerate(IntPtr page, ref int startPos, out IntPtr linkAnnot)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFLink_Enumerate(page, ref startPos, out linkAnnot);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static IntPtr FPDFLink_GetDest(IntPtr document, IntPtr link)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFLink_GetDest(document, link);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static uint FPDFDest_GetPageIndex(IntPtr document, IntPtr dest)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFDest_GetPageIndex(document, dest);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static bool FPDFLink_GetAnnotRect(IntPtr linkAnnot, FS_RECTF rect)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFLink_GetAnnotRect(linkAnnot, rect);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static void FPDF_DeviceToPage(IntPtr page, int start_x, int start_y, int size_x, int size_y, int rotate, int device_x, int device_y, out double page_x, out double page_y)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FPDF_DeviceToPage(page, start_x, start_y, size_x, size_y, rotate, device_x, device_y, out page_x, out page_y);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static void FPDF_PageToDevice(IntPtr page, int start_x, int start_y, int size_x, int size_y, int rotate, double page_x, double page_y, out int device_x, out int device_y)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FPDF_PageToDevice(page, start_x, start_y, size_x, size_y, rotate, page_x, page_y, out device_x, out device_y);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static IntPtr FPDFLink_GetAction(IntPtr link)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFLink_GetAction(link);
            }
            finally
            {
                LockEvent.Set();
            }
        }
        public static uint FPDFAction_GetURIPath(IntPtr document, IntPtr action, StringBuilder buffer, uint buflen)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFAction_GetURIPath(document, action, buffer, buflen);
            }
            finally
            {
                LockEvent.Set();
            }
        }
        public static IntPtr FPDF_BookmarkGetFirstChild(IntPtr document, IntPtr bookmark)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFBookmark_GetFirstChild(document, bookmark);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static IntPtr FPDF_BookmarkGetNextSibling(IntPtr document, IntPtr bookmark)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFBookmark_GetNextSibling(document, bookmark);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static uint FPDF_BookmarkGetTitle(IntPtr bookmark, byte[] buffer, uint buflen)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFBookmark_GetTitle(bookmark, buffer, buflen);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static IntPtr FPDF_BookmarkGetAction(IntPtr bookmark)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFBookmark_GetAction(bookmark);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static IntPtr FPDF_BookmarkGetDest(IntPtr document, IntPtr bookmark)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFBookmark_GetDest(document, bookmark);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static uint FPDF_ActionGetType(IntPtr action)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFAction_GetType(action);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        /// <summary>
        /// Opens a document using a .NET Stream. Allows opening huge
        /// PDFs without loading them into memory first.
        /// </summary>
        /// <param name="input">The input Stream. Don't dispose prior to closing the pdf.</param>
        /// <param name="password">Password, if the PDF is protected. Can be null.</param>
        /// <param name="id">Retrieves an IntPtr to the COM object for the Stream. The caller must release this with Marshal.Release prior to Disposing the Stream.</param>
        /// <returns>An IntPtr to the FPDF_DOCUMENT object.</returns>
        public static IntPtr FPDF_LoadCustomDocument(Stream input, string password, int id)
        {
            var getBlock = Marshal.GetFunctionPointerForDelegate(_getBlockDelegate);

            var access = new FPDF_FILEACCESS
            {
                m_FileLen = (uint)input.Length,
                m_GetBlock = getBlock,
                m_Param = (IntPtr)id
            };
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDF_LoadCustomDocument(access, password);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static FPDF_ERR FPDF_GetLastError()
        {
            LockEvent.WaitOne();
            try
            {
                return (FPDF_ERR)Imports.FPDF_GetLastError();
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static uint FPDF_GetMetaText(IntPtr document, string tag, byte[] buffer, uint buflen)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDF_GetMetaText(document, tag, buffer, buflen);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        #region Save / Edit Methods

        public static void FPDFPage_SetRotation(IntPtr page, PdfRotation rotation)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FPDFPage_SetRotation(page, (int)rotation);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static bool FPDFPage_GenerateContent(IntPtr page)
        {
            LockEvent.WaitOne();
            try
            {
                return Imports.FPDFPage_GenerateContent(page);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static void FPDFPage_Delete(IntPtr doc, int page)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FPDFPage_Delete(doc, page);
            }
            finally
            {
                LockEvent.Set();
            }
        }

        public static bool FPDF_SaveAsCopy(IntPtr doc, Stream output, FPDF_SAVE_FLAGS flags)
        {
            int id = StreamManager.Register(output);

            try
            {
                var write = new FPDF_FILEWRITE
                {
                    stream = (IntPtr)id,
                    version = 1,
                    WriteBlock = Marshal.GetFunctionPointerForDelegate(_saveBlockDelegate)
                };

                LockEvent.WaitOne();
                try
                {
                    return Imports.FPDF_SaveAsCopy(doc, write, flags);
                }
                finally
                {
                    LockEvent.Set();
                }
            }
            finally
            {
                StreamManager.Unregister(id);
            }
        }

        public static bool FPDF_SaveWithVersion(IntPtr doc, Stream output, FPDF_SAVE_FLAGS flags, int fileVersion)
        {
            int id = StreamManager.Register(output);

            try
            {
                var write = new FPDF_FILEWRITE
                {
                    stream = (IntPtr)id,
                    version = 1,
                    WriteBlock = Marshal.GetFunctionPointerForDelegate(_saveBlockDelegate)
                };

                LockEvent.WaitOne();
                try
                {
                    return Imports.FPDF_SaveWithVersion(doc, write, flags, fileVersion);
                }
                finally
                {
                    LockEvent.Set();
                }
            }
            finally
            {
                StreamManager.Unregister(id);
            }
        }

        public static void FPDF_FFLDraw(IntPtr form, IntPtr bitmap, IntPtr page, int start_x, int start_y, int size_x, int size_y, int rotate, FPDF flags)
        {
            LockEvent.WaitOne();
            try
            {
                Imports.FPDF_FFLDraw(form, bitmap, page, start_x, start_y, size_x, size_y, rotate, flags);
            }
            finally
            {
                LockEvent.Set();
            }
        }
        #endregion

        #region Custom Load/Save Logic
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int FPDF_GetBlockDelegate(IntPtr param, uint position, IntPtr buffer, uint size);

        private static readonly FPDF_GetBlockDelegate _getBlockDelegate = FPDF_GetBlock;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int FPDF_SaveBlockDelegate(IntPtr fileWrite, IntPtr data, uint size);

        private static readonly FPDF_SaveBlockDelegate _saveBlockDelegate = FPDF_SaveBlock;

        private static int FPDF_GetBlock(IntPtr param, uint position, IntPtr buffer, uint size)
        {
            var stream = StreamManager.Get((int)param);
            if (stream == null)
                return 0;
            byte[] managedBuffer = new byte[size];

            stream.Position = position;
            int read = stream.Read(managedBuffer, 0, (int)size);
            if (read != size)
                return 0;

            Marshal.Copy(managedBuffer, 0, buffer, (int)size);
            return 1;
        }

        private static int FPDF_SaveBlock(IntPtr fileWrite, IntPtr data, uint size)
        {
            var write = new FPDF_FILEWRITE();
            Marshal.PtrToStructure(fileWrite, write);

            var stream = StreamManager.Get((int)write.stream);
            if (stream == null)
                return 0;

            byte[] buffer = new byte[size];
            Marshal.Copy(data, buffer, 0, (int)size);

            try
            {
                stream.Write(buffer, 0, (int)size);
                return (int)size;
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        private static class Imports
        {
            private const string DLL_NAME = "pdfium";
            [DllImport(DLL_NAME)]
            public static extern void FPDF_InitLibrary();

            [DllImport(DLL_NAME)]
            public static extern void FPDF_DestroyLibrary();

            [DllImport(DLL_NAME, CharSet = CharSet.Ansi)]
            public static extern IntPtr FPDF_LoadCustomDocument([MarshalAs(UnmanagedType.LPStruct)] FPDF_FILEACCESS access, string password);

            [DllImport(DLL_NAME, CharSet = CharSet.Ansi)]
            public static extern IntPtr FPDF_LoadMemDocument(SafeHandle data_buf, int size, string password);

            [DllImport(DLL_NAME, CharSet = CharSet.Ansi)]
            public static extern IntPtr FPDF_LoadMemDocument(byte[] data_buf, int size, string password);

            [DllImport(DLL_NAME)]
            public static extern void FPDF_CloseDocument(IntPtr document);

            [DllImport(DLL_NAME)]
            public static extern int FPDF_GetPageCount(IntPtr document);

            [DllImport(DLL_NAME)]
            public static extern uint FPDF_GetDocPermissions(IntPtr document);

            [DllImport(DLL_NAME)]
            public static extern IntPtr FPDFDOC_InitFormFillEnvironment(IntPtr document, FPDF_FORMFILLINFO formInfo);

            [DllImport(DLL_NAME)]
            public static extern void FPDF_SetFormFieldHighlightColor(IntPtr hHandle, int fieldType, uint color);

            [DllImport(DLL_NAME)]
            public static extern void FPDF_SetFormFieldHighlightAlpha(IntPtr hHandle, byte alpha);

            [DllImport(DLL_NAME)]
            public static extern void FORM_DoDocumentJSAction(IntPtr hHandle);

            [DllImport(DLL_NAME)]
            public static extern void FORM_DoDocumentOpenAction(IntPtr hHandle);

            [DllImport(DLL_NAME)]
            public static extern void FPDFDOC_ExitFormFillEnvironment(IntPtr hHandle);

            [DllImport(DLL_NAME)]
            public static extern void FORM_DoDocumentAAction(IntPtr hHandle, FPDFDOC_AACTION aaType);

            [DllImport(DLL_NAME)]
            public static extern IntPtr FPDF_LoadPage(IntPtr document, int page_index);

            [DllImport(DLL_NAME)]
            public static extern IntPtr FPDFText_LoadPage(IntPtr page);

            [DllImport(DLL_NAME)]
            public static extern void FORM_OnAfterLoadPage(IntPtr page, IntPtr _form);

            [DllImport(DLL_NAME)]
            public static extern void FORM_DoPageAAction(IntPtr page, IntPtr _form, FPDFPAGE_AACTION fPDFPAGE_AACTION);

            [DllImport(DLL_NAME)]
            public static extern double FPDF_GetPageWidth(IntPtr page);

            [DllImport(DLL_NAME)]
            public static extern double FPDF_GetPageHeight(IntPtr page);

            [DllImport(DLL_NAME)]
            public static extern void FORM_OnBeforeClosePage(IntPtr page, IntPtr _form);

            [DllImport(DLL_NAME)]
            public static extern void FPDFText_ClosePage(IntPtr text_page);

            [DllImport(DLL_NAME)]
            public static extern void FPDF_ClosePage(IntPtr page);

            [DllImport(DLL_NAME)]
            public static extern void FPDF_RenderPage(IntPtr dc, IntPtr page, int start_x, int start_y, int size_x, int size_y, int rotate, FPDF flags);

            [DllImport(DLL_NAME)]
            public static extern void FPDF_RenderPageBitmap(IntPtr bitmapHandle, IntPtr page, int start_x, int start_y, int size_x, int size_y, int rotate, FPDF flags);

            [DllImport(DLL_NAME)]
            public static extern int FPDF_GetPageSizeByIndex(IntPtr document, int page_index, out double width, out double height);

            [DllImport(DLL_NAME)]
            public static extern IntPtr FPDFBitmap_Create(int width, int height, int alpha);

            [DllImport(DLL_NAME)]
            public static extern IntPtr FPDFBitmap_CreateEx(int width, int height, int format, IntPtr first_scan, int stride);

            [DllImport(DLL_NAME)]
            public static extern void FPDFBitmap_FillRect(IntPtr bitmapHandle, int left, int top, int width, int height, uint color);

            [DllImport(DLL_NAME)]
            public static extern IntPtr FPDFBitmap_Destroy(IntPtr bitmapHandle);

            [DllImport(DLL_NAME)]
            public static extern int FPDFBitmap_GetStride(IntPtr bitmap);
            [DllImport(DLL_NAME)]
            public static extern IntPtr FPDFBitmap_GetBuffer(IntPtr bitmap);

            [DllImport(DLL_NAME)]
            public static extern IntPtr FPDFText_FindStart(IntPtr page, byte[] findWhat, FPDF_SEARCH_FLAGS flags, int start_index);

            [DllImport(DLL_NAME)]
            public static extern int FPDFText_GetSchResultIndex(IntPtr handle);

            [DllImport(DLL_NAME)]
            public static extern int FPDFText_GetSchCount(IntPtr handle);

            [DllImport(DLL_NAME)]
            public static extern int FPDFText_GetText(IntPtr page, int start_index, int count, byte[] result);

            [DllImport(DLL_NAME)]
            public static extern void FPDFText_GetCharBox(IntPtr page, int index, out double left, out double right, out double bottom, out double top);

            [DllImport(DLL_NAME)]
            public static extern int FPDFText_CountChars(IntPtr page);

            [DllImport(DLL_NAME)]
            public static extern bool FPDFText_FindNext(IntPtr handle);

            [DllImport(DLL_NAME)]
            public static extern void FPDFText_FindClose(IntPtr handle);

            [DllImport(DLL_NAME)]
            public static extern bool FPDFLink_Enumerate(IntPtr page, ref int startPos, out IntPtr linkAnnot);

            [DllImport(DLL_NAME)]
            public static extern IntPtr FPDFLink_GetDest(IntPtr document, IntPtr link);

            [DllImport(DLL_NAME)]
            public static extern uint FPDFDest_GetPageIndex(IntPtr document, IntPtr dest);

            [DllImport(DLL_NAME)]
            public static extern bool FPDFLink_GetAnnotRect(IntPtr linkAnnot, FS_RECTF rect);

            [DllImport(DLL_NAME)]
            public static extern void FPDF_DeviceToPage(IntPtr page, int start_x, int start_y, int size_x, int size_y, int rotate, int device_x, int device_y, out double page_x, out double page_y);

            [DllImport(DLL_NAME)]
            public static extern void FPDF_PageToDevice(IntPtr page, int start_x, int start_y, int size_x, int size_y, int rotate, double page_x, double page_y, out int device_x, out int device_y);

            [DllImport(DLL_NAME)]
            public static extern IntPtr FPDFLink_GetAction(IntPtr link);

            [DllImport(DLL_NAME)]
            public static extern uint FPDFAction_GetURIPath(IntPtr document, IntPtr action, StringBuilder buffer, uint buflen);

            [DllImport(DLL_NAME)]
            public static extern IntPtr FPDFBookmark_GetFirstChild(IntPtr document, IntPtr bookmark);

            [DllImport(DLL_NAME)]
            public static extern IntPtr FPDFBookmark_GetNextSibling(IntPtr document, IntPtr bookmark);

            [DllImport(DLL_NAME)]
            public static extern uint FPDFBookmark_GetTitle(IntPtr bookmark, byte[] buffer, uint buflen);

            [DllImport(DLL_NAME)]
            public static extern IntPtr FPDFBookmark_GetAction(IntPtr bookmark);

            [DllImport(DLL_NAME)]
            public static extern IntPtr FPDFBookmark_GetDest(IntPtr document, IntPtr bookmark);

            [DllImport(DLL_NAME)]
            public static extern uint FPDFAction_GetType(IntPtr action);

            [DllImport(DLL_NAME)]
            public static extern uint FPDF_GetLastError();

            [DllImport(DLL_NAME)]
            public static extern uint FPDF_GetMetaText(IntPtr document, string tag, byte[] buffer, uint buflen);

            #region Save/Edit APIs

            [DllImport(DLL_NAME)]
            public static extern bool FPDF_ImportPages(IntPtr destDoc, IntPtr srcDoc, [MarshalAs(UnmanagedType.LPStr)] string pageRange, int index);

            [DllImport(DLL_NAME)]
            public static extern bool FPDF_SaveAsCopy(IntPtr doc,
                [MarshalAs(UnmanagedType.LPStruct)] FPDF_FILEWRITE writer,
                [MarshalAs(UnmanagedType.I4)] FPDF_SAVE_FLAGS flag);

            [DllImport(DLL_NAME)]
            public static extern bool FPDF_SaveWithVersion(IntPtr doc,
                [MarshalAs(UnmanagedType.LPStruct)] FPDF_FILEWRITE writer,
                [MarshalAs(UnmanagedType.I4)] FPDF_SAVE_FLAGS flags,
                int fileVersion);

            [DllImport(DLL_NAME)]
            public static extern IntPtr FPDFPage_New(IntPtr doc, int index, double width, double height);

            [DllImport(DLL_NAME)]
            public static extern void FPDFPage_Delete(IntPtr doc, int index);

            [DllImport(DLL_NAME)]
            public static extern int FPDFPage_GetRotation(IntPtr page);

            [DllImport(DLL_NAME)]
            public static extern void FPDFPage_SetRotation(IntPtr page, int rotate);

            [DllImport(DLL_NAME)]
            public static extern IntPtr FPDF_CreateNewDocument();

            [DllImport(DLL_NAME)]
            public static extern IntPtr FPDFPageObj_NewImgeObj(IntPtr document);

            [DllImport(DLL_NAME)]
            public static extern bool FPDFImageObj_SetBitmap(IntPtr pages, int count, IntPtr imageObject, IntPtr bitmap);

            [DllImport(DLL_NAME)]
            public static extern void FPDFPageObj_Transform(IntPtr page, double a, double b, double c, double d, double e, double f);

            [DllImport(DLL_NAME)]
            public static extern void FPDFPage_InsertObject(IntPtr page, IntPtr pageObject);

            [DllImport(DLL_NAME)]
            public static extern bool FPDFPage_GenerateContent(IntPtr page);

            [DllImport(DLL_NAME)]
            public static extern void FPDF_FFLDraw(IntPtr form, IntPtr bitmap, IntPtr page, int start_x, int start_y, int size_x, int size_y, int rotate, FPDF flags);

            #endregion
        }

        [StructLayout(LayoutKind.Sequential)]
        public class FPDF_FORMFILLINFO
        {
            public int version;

            private IntPtr Release;

            private IntPtr FFI_Invalidate;

            private IntPtr FFI_OutputSelectedRect;

            private IntPtr FFI_SetCursor;

            private IntPtr FFI_SetTimer;

            private IntPtr FFI_KillTimer;

            private IntPtr FFI_GetLocalTime;

            private IntPtr FFI_OnChange;

            private IntPtr FFI_GetPage;

            private IntPtr FFI_GetCurrentPage;

            private IntPtr FFI_GetRotation;

            private IntPtr FFI_ExecuteNamedAction;

            private IntPtr FFI_SetTextFieldFocus;

            private IntPtr FFI_DoURIAction;

            private IntPtr FFI_DoGoToAction;

            private IntPtr m_pJsPlatform;

            // XFA support i.e. version 2

            private IntPtr FFI_DisplayCaret;

            private IntPtr FFI_GetCurrentPageIndex;

            private IntPtr FFI_SetCurrentPage;

            private IntPtr FFI_GotoURL;

            private IntPtr FFI_GetPageViewRect;

            private IntPtr FFI_PageEvent;

            private IntPtr FFI_PopupMenu;

            private IntPtr FFI_OpenFile;

            private IntPtr FFI_EmailTo;

            private IntPtr FFI_UploadTo;

            private IntPtr FFI_GetPlatform;

            private IntPtr FFI_GetLanguage;

            private IntPtr FFI_DownloadFromURL;

            private IntPtr FFI_PostRequestURL;

            private IntPtr FFI_PutRequestURL;
        }

        public enum FPDF_UNSP
        {
            DOC_XFAFORM = 1,
            DOC_PORTABLECOLLECTION = 2,
            DOC_ATTACHMENT = 3,
            DOC_SECURITY = 4,
            DOC_SHAREDREVIEW = 5,
            DOC_SHAREDFORM_ACROBAT = 6,
            DOC_SHAREDFORM_FILESYSTEM = 7,
            DOC_SHAREDFORM_EMAIL = 8,
            ANNOT_3DANNOT = 11,
            ANNOT_MOVIE = 12,
            ANNOT_SOUND = 13,
            ANNOT_SCREEN_MEDIA = 14,
            ANNOT_SCREEN_RICHMEDIA = 15,
            ANNOT_ATTACHMENT = 16,
            ANNOT_SIG = 17
        }

        public enum FPDFDOC_AACTION
        {
            WC = 0x10,
            WS = 0x11,
            DS = 0x12,
            WP = 0x13,
            DP = 0x14
        }

        public enum FPDFPAGE_AACTION
        {
            OPEN = 0,
            CLOSE = 1
        }

        [Flags]
        public enum FPDF
        {
            ANNOT = 0x01,
            LCD_TEXT = 0x02,
            NO_NATIVETEXT = 0x04,
            GRAYSCALE = 0x08,
            DEBUG_INFO = 0x80,
            NO_CATCH = 0x100,
            RENDER_LIMITEDIMAGECACHE = 0x200,
            RENDER_FORCEHALFTONE = 0x400,
            PRINTING = 0x800,
            REVERSE_BYTE_ORDER = 0x10
        }

        [Flags]
        public enum FPDF_SEARCH_FLAGS
        {
            FPDF_MATCHCASE = 1,
            FPDF_MATCHWHOLEWORD = 2
        }

        [StructLayout(LayoutKind.Sequential)]
        public class FS_RECTF
        {
            public float left;
            public float top;
            public float right;
            public float bottom;
        }

        public enum FPDF_ERR : uint
        {
            FPDF_ERR_SUCCESS = 0,		// No error.
            FPDF_ERR_UNKNOWN = 1,		// Unknown error.
            FPDF_ERR_FILE = 2,		// File not found or could not be opened.
            FPDF_ERR_FORMAT = 3,		// File not in PDF format or corrupted.
            FPDF_ERR_PASSWORD = 4,		// Password required or incorrect password.
            FPDF_ERR_SECURITY = 5,		// Unsupported security scheme.
            FPDF_ERR_PAGE = 6		// Page not found or content error.
        }

        #region Save/Edit Structs and Flags
        [Flags]
        public enum FPDF_SAVE_FLAGS
        {
            FPDF_INCREMENTAL = 1,
            FPDF_NO_INCREMENTAL = 2,
            FPDF_REMOVE_SECURITY = 3
        }

        [StructLayout(LayoutKind.Sequential)]
        public class FPDF_FILEACCESS
        {
            public uint m_FileLen;
            public IntPtr m_GetBlock;
            public IntPtr m_Param;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class FPDF_FILEWRITE
        {
            public int version;
            public IntPtr WriteBlock;
            public IntPtr stream;
        }
        #endregion
    }
}
