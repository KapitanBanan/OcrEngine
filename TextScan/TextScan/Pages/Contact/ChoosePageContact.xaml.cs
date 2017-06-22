using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Media.Ocr;
using Windows.Globalization;
using Windows.Graphics.Imaging;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Media.Capture;


namespace TextScan.Pages.Contact
{
    public sealed partial class ChoosePageContact : Page
    {
        public ChoosePageContact()
        {
            this.InitializeComponent();
        }

    

        private async void ClickBrowse(object sender, RoutedEventArgs e)
        {
            FileOpenPicker fileOpenPicker = new FileOpenPicker();
            fileOpenPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            fileOpenPicker.FileTypeFilter.Add(".jpg");
            fileOpenPicker.ViewMode = PickerViewMode.Thumbnail;

            var inputFile = await fileOpenPicker.PickSingleFileAsync();

            if (inputFile == null)
            {
                return;
            }

            SoftwareBitmap bitmap;

            using (IRandomAccessStream stream = await inputFile.OpenAsync(FileAccessMode.Read))
            {
                BitmapDecoder decoder = await BitmapDecoder.CreateAsync(stream);
                
                bitmap = await decoder.GetSoftwareBitmapAsync();
            }

            Language ocrLanguage = new Language("en");
            OcrEngine ocrEngine = OcrEngine.TryCreateFromUserProfileLanguages();
            OcrResult ocrResult = await ocrEngine.RecognizeAsync(bitmap);

            string result = ocrResult.Text;
            Frame.Navigate(typeof(SelectTextPageContact), result);
        }

        private async void ClickMakePhoto(object sender, RoutedEventArgs e)
        {
            CameraCaptureUI captureUI = new CameraCaptureUI();
            captureUI.PhotoSettings.Format = CameraCaptureUIPhotoFormat.Jpeg;

            StorageFile photo = await captureUI.CaptureFileAsync(CameraCaptureUIMode.Photo);

            if (photo == null)
            {
                return;
            }

            IRandomAccessStream stream = await photo.OpenAsync(FileAccessMode.Read);
            BitmapDecoder decoder = await BitmapDecoder.CreateAsync(stream);
            SoftwareBitmap bitmap = await decoder.GetSoftwareBitmapAsync();

            Language ocrLanguage = new Language("en");
            OcrEngine ocrEngine = OcrEngine.TryCreateFromUserProfileLanguages();
            OcrResult ocrResult = await ocrEngine.RecognizeAsync(bitmap);

            //photo = new ApplicationData.LocalFolder();

            string result = ocrResult.Text;
            Frame.Navigate(typeof(SelectTextPageContact), result);
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PageStart));
        }
    }
}
