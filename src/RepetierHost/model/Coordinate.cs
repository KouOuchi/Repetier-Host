using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using QuickFont;
using RepetierHost.model.geom;

namespace RepetierHost.model
{
    class Coordinate
    {
        #region defines
        const int area_size = 80;
        const int margin = 16;
        const int label_font_size = 16;
        readonly Vector4 z_unit = new Vector4(0.0f, 0.0f, area_size, 0.0f);
        readonly int[] coordinate_colors = 
        {
            Submesh.ColorToRgba32(System.Drawing.Color.Indigo), //x axis
            Submesh.ColorToRgba32(System.Drawing.Color.SkyBlue), //y axis
            Submesh.ColorToRgba32(System.Drawing.Color.Red) //z axis                                       
        };
        readonly OpenTK.Graphics.Color4[] label_colors = 
        {
            OpenTK.Graphics.Color4.Indigo, // x axis
            OpenTK.Graphics.Color4.SkyBlue, //y axis
            OpenTK.Graphics.Color4.Red // z axis                                                        
        };
        #endregion

        Submesh[] submesh = null;
        TopoModel model = null;
        QFont font;
        float arrow_length;

        internal Coordinate()
        {
            submesh = new Submesh[3];
            model = new TopoModel();

            // import mesh from STL.
            model.importSTL("data/Arrow.stl");
            arrow_length = Convert.ToSingle(Math.Abs(model.boundingBox.zMax - model.boundingBox.zMin));

            // override mesh color
            for (int i = 0; i < 3; i++)
            {
                submesh[i] = new Submesh();
                model.FillMesh(submesh[i], 0);
                submesh[i].Compress(true, coordinate_colors[i]);
                submesh[i].vertices.Clear();
            }

            // config font
            font = new QFont("data/HappySans.ttf",
                label_font_size, new QFontBuilderConfiguration(true));
            font.Options.DropShadowActive = false;
        }

        internal void Draw(int viewport_x, int viewport_y, double rotX, double rotZ)
        {
            GL.MatrixMode(MatrixMode.Projection);
            GL.PushMatrix(); // push projection
            GL.LoadIdentity();

            GL.MatrixMode(MatrixMode.Modelview);
            GL.PushMatrix(); // push modelview
            GL.LoadIdentity();

            GL.Viewport(0, 0, area_size, area_size); // change viewport
            float length = area_size * 0.5f + margin * 2.0f;
            GL.Ortho(-length, length, -length, length, -length, length);

            GL.Rotate(rotX / Math.PI * 180D, -1D, 0D, 0D);
            GL.Rotate(rotZ / Math.PI * 180D, 0D, 0D, -1D);

            DrawArrow();
            DrawLabel();

            GL.Viewport(0, 0, viewport_x, viewport_y); // restore viewport

            GL.PopMatrix();
            GL.PopMatrix();
        }

        private void DrawArrow()
        {
            // Draw Z coordinate
            submesh[2].Draw(Main.threeDSettings.drawMethod, Main.main.threedview.cam.EdgeTranslation());

            // Draw Y coordinated
            GL.PushMatrix();
            GL.Rotate(90.0d, 0.0d, 1.0d, 0.0d);
            submesh[1].Draw(Main.threeDSettings.drawMethod, Main.main.threedview.cam.EdgeTranslation());
            GL.PopMatrix();

            // Draw X coordinated
            GL.PushMatrix();
            GL.Rotate(90.0d, 1.0d, 0.0d, 0.0d);
            submesh[0].Draw(Main.threeDSettings.drawMethod, Main.main.threedview.cam.EdgeTranslation());
            GL.PopMatrix();
        }

        private void DrawLabel()
        {
            Matrix4 movelview;
            GL.GetFloat(GetPName.ModelviewMatrix, out movelview);

            float len = area_size / 2.0f * arrow_length;
            Vector4 pos_x = Vector4.Transform(-Vector4.UnitY * len, movelview);
            Vector4 pos_y = Vector4.Transform(Vector4.UnitX * len, movelview);
            Vector4 pos_z = Vector4.Transform(Vector4.UnitZ * len, movelview);

            QFont.Begin();
            GL.PushMatrix();
            GL.Disable(EnableCap.DepthTest);
            GL.Disable(EnableCap.Lighting);
            // translate to center
            GL.Translate(area_size * 0.5f, area_size * 0.5f - label_font_size, 0f);

            Vector2 translate_x = new Vector2(pos_x.X, -pos_x.Y - label_font_size / 2.0f);
            Vector2 translate_y = new Vector2(pos_y.X, -pos_y.Y - label_font_size / 2.0f);
            Vector2 translate_z = new Vector2(pos_z.X, -pos_z.Y - label_font_size / 2.0f);

            font.Options.Colour = label_colors[0];
            font.Print("x", QFontAlignment.Left, translate_x);
            font.Options.Colour = label_colors[1];
            font.Print("y", QFontAlignment.Right, translate_y);
            font.Options.Colour = label_colors[2];
            font.Print("z", QFontAlignment.Left, translate_z);

            GL.Disable(EnableCap.Texture2D); // QFont doesn't restor Texture2D. 
            GL.Disable(EnableCap.Blend); // QFont doesn't restore Blend.

            GL.Enable(EnableCap.Lighting);
            GL.Enable(EnableCap.DepthTest);
            GL.PopMatrix();
            QFont.End();
        }
    }
}
