using System.Net.Http;
using ZwSoft.ZwCAD.ApplicationServices;
using ZwSoft.ZwCAD.EditorInput;
using ZwSoft.ZwCAD.Geometry;
using ZwSoft.ZwCAD.Runtime;

namespace GetHeighByCoordinates
{
    public static class Commands
    {
        [CommandMethod("CK_GetHbyXY")]
        public static void GetHaightByCoordinateXY()
        {
            var (X, Y) = ConvertPoint3dToCoordinate(GetPoint());
            var height = GetHeight(X, Y);
            Application.DocumentManager.MdiActiveDocument.Editor.WriteMessage($"\n{height}");
        }

        public static string GetHeight(double coordinateX, double coordinateY)
        {
            string url = $"https://services.gugik.gov.pl/nmt/?request=GetHByXY&x={coordinateX}&y={coordinateY}";

            return new HttpClient().GetAsync(url).Result.Content.ReadAsStringAsync().Result;
        }

        private static Point3d GetPoint()
        {
            PromptPointOptions pPtOpts = new PromptPointOptions("\nWskaz punkt na mapie: ");
            PromptPointResult pPtRes = Application.DocumentManager.MdiActiveDocument.Editor.GetPoint(pPtOpts);
            
            return  pPtRes.Value;
        }

        private static (double X, double Y) ConvertPoint3dToCoordinate(Point3d point)
        {
            // convert pick point to coordinates
            
            return ( point.X, point.Y );
        }
    }
}
