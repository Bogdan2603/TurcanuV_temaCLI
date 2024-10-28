# ȚurcanuV_tema03

1.a

Antiorar. Comentand desenarea axei X, dispare linia din dreapta. Comentand desenarea axei y dispare linia de sus

1.b 

Rezolvare:

```csharp
private void DrawAxes() {

GL.Begin(PrimitiveType.Lines);

GL.Color3(Color.Red);

GL.Vertex3(0, 0, 0);

GL.Vertex3(XYZ_SIZE, 0, 0);

GL.Color3(Color.Yellow);

GL.Vertex3(0, 0, 0);

GL.Vertex3(0, XYZ_SIZE, 0);

GL.Color3(Color.Green);

GL.Vertex3(0, 0, 0);

GL.Vertex3(0, 0, XYZ_SIZE);

GL.End();
```

2.

Anti-aliasing funcționează prin adăugarea de pixeli gri de-a lungul marginii unei linii sau curbe pentru a se amesteca cu culoarea de fundal. Acest proces de amestecare reduce vizibilitatea marginilor zimțate, astfel încât acestea par mai fine și mai puțin vizibile.

3.a

Se modifica grosimea liniilor desenate

3.b

Se modifica grosimea punctelor desenate

3.c

Nu.  Metoda GL.begin()  aplica setarile tuturor entitatilor care au fost declarate inaintea inceperii executarii sale

4.a

LineLoop deseneaza linii care conectează toate punctele succesive într-o buclă, unde ultima linie conecteaza ultimul punct cu primul.

4.b

LineStrip are functia asemanatoare cu LineLoop, unica diferenta fiind neconectarea primului si ultimului punct printr-o linie.

4.c

TriangleFan folosește primul punct specificat ca punct central, iar toate celelalte puncte formează triunghiuri conectate la acest punct central. Fiecare punct nou va avea ca puncta commune primul punct central, si punctul precedent.

4.d

TriangleStrip conectează punctele specificate (minimum 3) pentru a forma o bandă continuă de triunghiuri, unde fiecare nou punct, împreună cu cele două puncte anterioare, formează un triunghi.

6.

1. Distingerea usoara a mai multor entitati
2. Simularea efectelor de lumina si umbra

7.a

Un gradient este o tranzitie usoara intre 2 sau mai multe culori

7.b

De exemplu creand un triunghi, si dandu-i punctelor sale diferite culori

Rezolvare:

```csharp
private void DrawAxes() {

//  Triangle with Gradient

GL.Begin(PrimitiveType.Triangles);

GL.Color3(Color.AliceBlue);

GL.Vertex2(-2, -2);

GL.Color3(Color.Red);

GL.Vertex2(2, -2);

GL.Color3(Color.Green);

GL.Vertex2(2, 2);

GL.End();

}
```

EX 8, 9

```csharp
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);

        GL.Viewport(0, 0, Width, Height);

        double aspect_ratio = Width / (double)Height;

        Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, (float)aspect_ratio, 0.1f, 100f);
        GL.MatrixMode(MatrixMode.Projection);
        GL.LoadMatrix(ref perspective);

        //Matrix4 lookat = Matrix4.LookAt(15, 15, 20, 0, 0, 0, 0, 1, 0);
        //GL.MatrixMode(MatrixMode.Modelview);
        //GL.LoadMatrix(ref lookat);
    }

    KeyboardState keyboard;
    protected override void OnUpdateFrame(FrameEventArgs e)
    {
        base.OnUpdateFrame(e);

        keyboard = Keyboard.GetState();
        MouseState mouse = Mouse.GetState();
        EYE_X = mouse.X ;
        EYE_Y = mouse.Y ;
        EYE_X /= 4;
        EYE_Y /= 4;

        if(keyboard.IsKeyDown(Key.A))
        {
            x += 1;
        }
        if (keyboard.IsKeyDown(Key.D))
        {
            x -= 1;
        }
        if (keyboard.IsKeyDown(Key.W))
        {
            z += 1;
        }
        if (keyboard.IsKeyDown(Key.S))
        {
            z -= 1;
        }

        if (keyboard.IsKeyDown(Key.ShiftLeft))
        {
            y -= 1;
        }

        if (keyboard.IsKeyDown(Key.Space))
        {
            y += 1;
        }

    }

    int x = 0,  z = 0, y = 0;
    protected override void OnRenderFrame(FrameEventArgs e)
    {
        base.OnRenderFrame(e);

        // Transparency enabled
        GL.Enable(EnableCap.Blend);
        GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);

        GL.Clear(ClearBufferMask.ColorBufferBit);
        GL.Clear(ClearBufferMask.DepthBufferBit);

        Matrix4 lookat = Matrix4.LookAt( 1 , 1, 10 , EYE_X, -EYE_Y, 0, 0, 1, 0);
        GL.MatrixMode(MatrixMode.Modelview);
        GL.LoadMatrix(ref lookat);
        //GL.LoadIdentity();
        

        GL.Translate(x, -y, z);

        // TriangelStrip with Gradient

        GL.Begin(PrimitiveType.TriangleStrip);

        if(keyboard.IsKeyDown(Key.R))
        {
            GL.Color3(Color.Blue);
        }
        else
        {
            GL.Color3(Color.Yellow);
        }
        GL.Vertex2(-2, -2);

        // Transparency view
        if (keyboard.IsKeyDown(Key.P))
        {
            GL.Color4(0.8,0.1, 0.5, 1);
        }
        else
        {
            GL.Color4(0.8, 0.1, 0.5, 0.1);
        }
        GL.Vertex2(2, -2);

        if (keyboard.IsKeyDown(Key.T))
        {
            GL.Color4(0.1, 0.1, 0.1, 1);
        }
        else
        {
            GL.Color4(0.7, 0.1, 0.7, 0.6);
        }
        GL.Vertex2(2, 2);

        GL.End();

        SwapBuffers();
    }

}
```

Ex 10

Se aplica gradientul, ca si la ex 7.b
