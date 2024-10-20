using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace OpenTK_immediate_mode
{
    class ImmediateMode : GameWindow
    {

        private const int XYZ_SIZE = 20;

        public ImmediateMode() : base(800, 600, new GraphicsMode(32, 24, 0, 8)) {
            VSync = VSyncMode.On;

            Console.WriteLine("OpenGl versiunea: " + GL.GetString(StringName.Version));
            Title = "OpenGl versiunea: " + GL.GetString(StringName.Version) + " (mod imediat)";

        }

        /**Setare mediu OpenGL și încarcarea resurselor (dacă e necesar) - de exemplu culoarea de
           fundal a ferestrei 3D.
           Atenție! Acest cod se execută înainte de desenarea efectivă a scenei 3D. */
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            GL.ClearColor(Color.Blue);
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Less);
            GL.Hint(HintTarget.PolygonSmoothHint, HintMode.Nicest);
        }

        /**Inițierea afișării și setarea viewport-ului grafic. Metoda este invocată la redimensionarea
           ferestrei. Va fi invocată o dată și imediat după metoda ONLOAD()!
           Viewport-ul va fi dimensionat conform mărimii ferestrei active (cele 2 obiecte pot avea și mărimi 
           diferite). */
        protected override void OnResize(EventArgs e) {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);

            double aspect_ratio = Width / (double)Height;

            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, (float)aspect_ratio, 1, 64);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspective);

            Matrix4 lookat = Matrix4.LookAt(30, 30, 30, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref lookat);


        }

        /** Secțiunea pentru "game logic"/"business logic". Tot ce se execută în această secțiune va fi randat
            automat pe ecran în pasul următor - control utilizator, actualizarea poziției obiectelor, etc. */
        protected override void OnUpdateFrame(FrameEventArgs e) {
            base.OnUpdateFrame(e);

            KeyboardState keyboard = Keyboard.GetState();
            MouseState mouse = Mouse.GetState();

            if (keyboard[Key.Escape]) {
                Console.WriteLine("Pressed ESC key!");

                Exit();
            }

            // Modificat
            if (keyboard[Key.R])
            {
                GL.ClearColor(Color.White);
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

                GL.Color3(Color.Red);
                Console.WriteLine("Pressed R key!");
            }

            if (keyboard[Key.Y])
            {
                GL.Color3(Color.Yellow);
            }
        }

        /** Secțiunea pentru randarea scenei 3D. Controlată de modulul logic din metoda ONUPDATEFRAME().
            Parametrul de intrare "e" conține informatii de timing pentru randare. */
        protected override void OnRenderFrame(FrameEventArgs e) {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Clear(ClearBufferMask.DepthBufferBit);




            DrawAxes();

            DrawObjects();



            // Se lucrează în modul DOUBLE BUFFERED - câtă vreme se afișează o imagine randată, o alta se randează în background apoi cele 2 sunt schimbate...
            SwapBuffers();
        }


        // Cod Modificat
        private void DrawAxes() {

            //GL.LineWidth(3.0f);
            GL.PointSize(30.0f);
            GL.LineWidth(3.0f);

            // TriangleFan changing colors with keyboard

            GL.Begin(PrimitiveType.TriangleFan);
           // GL.Color3(Color.White);
            GL.Vertex2(-2, -2);
            GL.Vertex2(2, -2);
            GL.Vertex2(2, 2);
            //GL.End();



            // TriangelStrip with Gradient

            //GL.Begin(PrimitiveType.TriangleStrip);
            //GL.Color3(Color.Blue);
            //GL.Vertex2(-2, -2);

            //GL.Color3(Color.Green);
            //GL.Vertex2(2, -2);

            //GL.Color3(Color.Red);
            //GL.Vertex2(2, 2);
            //////GL.Vertex2(-2, 2);
            //GL.End();



            //  Triangle with Gradient

            /*GL.Begin(PrimitiveType.Triangles);
            GL.Color3(Color.AliceBlue);
            GL.Vertex2(-2, -2);

            GL.Color3(Color.Red);
            GL.Vertex2(2, -2);

            GL.Color3(Color.Green);
            GL.Vertex2(2, 2);
            //GL.Vertex2(-5, 5);
            GL.End();*/




            // TriangleFan

            //GL.Begin(PrimitiveType.TriangleFan);
            //GL.Color3(Color.AliceBlue);
            //GL.Vertex2(-2, -2);
            //GL.Vertex2(2, -2);
            //GL.Vertex2(2, 2);
            //GL.Vertex2(-5, 5);
            //GL.End();



            // TriangelStrip

            //GL.Begin(PrimitiveType.TriangleStrip);
            //GL.Color3(Color.AliceBlue);
            //GL.Vertex2(-2, -2);
            //GL.Vertex2(2, -2);
            //GL.Vertex2(2, 2);
            ////GL.Vertex2(-2, 2);
            //GL.End();


            // LineStreep

            //GL.Begin(PrimitiveType.LineStrip);

            //GL.Vertex2(-2, -2);
            //GL.Vertex2(2, -2);
            //GL.Vertex2(2, 2);
            //GL.Vertex2(-2, 2);
            //GL.End();



            // LineLoop
            //GL.Begin(PrimitiveType.LineLoop);

            //GL.Vertex2(-2 , -2);
            //GL.Vertex2( 2, -2);
            //GL.Vertex2( 2, 2);
            //GL.Vertex2( -2, 2);
            //GL.End();


            /*GL.Begin(PrimitiveType.Lines);

            // X
            GL.Color3(Color.Red);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(XYZ_SIZE, 0, 0);
            //GL.End();

            // Y
            GL.Color3(Color.Yellow);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, XYZ_SIZE, 0); ;
            //GL.End();

            // Z
            GL.Color3(Color.Green);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 0, XYZ_SIZE);
            GL.End();*/

            //// Points
            //GL.Begin(PrimitiveType.Points);
            //GL.Color3(Color.Pink);
            //GL.Vertex3(15, 10, 15);
            //GL.Vertex3(15, 10, 10);
            //GL.End();

        }

        private void DrawObjects() {



        }


        [STAThread]
        static void Main(string[] args) {

            /**Utilizarea cuvântului-cheie "using" va permite dealocarea memoriei o dată ce obiectul nu mai este
               în uz (vezi metoda "Dispose()").
               Metoda "Run()" specifică cerința noastră de a avea 30 de evenimente de tip UpdateFrame per secundă
               și un număr nelimitat de evenimente de tip randare 3D per secundă (maximul suportat de subsistemul
               grafic). Asta nu înseamnă că vor primi garantat respectivele valori!!!
               Ideal ar fi ca după fiecare UpdateFrame să avem si un RenderFrame astfel încât toate obiectele generate
               în scena 3D să fie actualizate fără pierderi (desincronizări între logica aplicației și imaginea randată
               în final pe ecran). */
            using (ImmediateMode example = new ImmediateMode()) {
                example.Run(30.0, 0.0); // first parameter is the most important
            }




        }
    }

}
