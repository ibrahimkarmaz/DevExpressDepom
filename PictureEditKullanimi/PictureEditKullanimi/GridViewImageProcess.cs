using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureEditKullanimi
{
    class GridViewImageProcess
    {
        /*NOT:
         GrridView Üzerinde Resim ekleneceği zaman kullanılır.
        Kullanım yapısı;
        Kullanılacak form içine ekleme yap
        private void GViewTabloGoster_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e) 
        Üsteki kısım ise GridView in olaylarından aç ve içine ekleme yap.
         */


        /*  void AddUnboundColumn(GridView view)
          {
              // Create an unbound column.
              GridColumn colImage = new GridColumn();
              colImage.FieldName = "Image";
              colImage.Caption = "AFİŞ";
              colImage.UnboundType = UnboundColumnType.Object;
              colImage.OptionsColumn.AllowEdit = false;
              colImage.Visible = true;

              // Add the Image column to the grid's Columns collection.
              view.Columns.Add(colImage);
          }
          void AssignPictureEdittoImageColumn(GridColumn column)
          {
              // Create and customize the PictureEdit repository item.
              RepositoryItemPictureEdit riPictureEdit = new RepositoryItemPictureEdit();
              riPictureEdit.SizeMode = PictureSizeMode.Zoom;

              // Add the PictureEdit to the grid's RepositoryItems collection.
              GControlDatabase.RepositoryItems.Add(riPictureEdit);

              // Assign the PictureEdit to the 'Image' column.
              column.ColumnEdit = riPictureEdit;
          }
           Dictionary<string, Image> imageCache = new Dictionary<string, Image>(StringComparer.OrdinalIgnoreCase);
          private void GViewTabloGoster_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
          {
              if (e.Column.FieldName == "Image" && e.IsGetData)
              {
                  GridView view = sender as GridView;
                  string fileName = view.GetRowCellValue(view.GetRowHandle(e.ListSourceRowIndex), "FilmAfisResim") as string ?? string.Empty;
                  if (!imageCache.ContainsKey(fileName))
                  {
                      Image img = null;
                      if (File.Exists(fileName))
                          img = Image.FromFile(fileName);
                      else
                          img = Image.FromFile(@"image\AfisYok.jpg");

                      imageCache.Add(fileName, img);
                  }
                  e.Value = imageCache[fileName];
              }
          }*/
    }
}
