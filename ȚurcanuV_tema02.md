# Tema 02 EGC

### *1.*

Se schimba pozitia si unghiul camerei

### *2.a*

```csharp
protected override void OnUpdateFrame(FrameEventArgs e)
{
    base.OnUpdateFrame(e);

    KeyboardState keyboard = Keyboard.GetState();
    MouseState mouse = Mouse.GetState();

    if (keyboard[Key.W])
    {
        EYE_Y++;
        Console.WriteLine(EYE_Y);

    }

    if (keyboard[Key.S])
    {
        EYE_Y--;
        Console.WriteLine(EYE_Y);

    }

    if (keyboard[Key.A])
    {
        EYE_X++;
        Console.WriteLine(EYE_Y);
    }

    if (keyboard[Key.D])
    {
        EYE_X--;
        Console.WriteLine(EYE_Y);
    }

}

protected override void OnRenderFrame(FrameEventArgs e)
{
    base.OnRenderFrame(e);

    GL.Clear(ClearBufferMask.ColorBufferBit);
    GL.Clear(ClearBufferMask.DepthBufferBit);

    Matrix4 lookat = Matrix4.LookAt(EYE_X , EYE_Y, 20, 0, 0, 0, 0, 1, 0);
    GL.MatrixMode(MatrixMode.Modelview);
    GL.LoadMatrix(ref lookat);

    // TriangelStrip with Gradient

    GL.Begin(PrimitiveType.TriangleStrip);
    GL.Color3(Color.Blue);
    GL.Vertex2(-2, -2);

    GL.Color3(Color.Green);
    GL.Vertex2(2, -2);

    GL.Color3(Color.Red);
    GL.Vertex2(2, 2);
    
    GL.End();

    SwapBuffers();
}
```

### ***2.b***

```csharp
protected override void OnUpdateFrame(FrameEventArgs e)
{
    base.OnUpdateFrame(e);

    MouseState mouse = Mouse.GetState();
    EYE_X = mouse.X ;
    EYE_Y = mouse.Y ;
}

protected override void OnRenderFrame(FrameEventArgs e)
{
    base.OnRenderFrame(e);

    GL.Clear(ClearBufferMask.ColorBufferBit);
    GL.Clear(ClearBufferMask.DepthBufferBit);

    Matrix4 lookat = Matrix4.LookAt(EYE_X , EYE_Y, 20, 0, 0, 0, 0, 1, 0);
    GL.MatrixMode(MatrixMode.Modelview);
    GL.LoadMatrix(ref lookat);

    // TriangelStrip with Gradient

    GL.Begin(PrimitiveType.TriangleStrip);
    GL.Color3(Color.Blue);
    GL.Vertex2(-2, -2);

    GL.Color3(Color.Green);
    GL.Vertex2(2, -2);

    GL.Color3(Color.Red);
    GL.Vertex2(2, 2);
    
    GL.End();

    SwapBuffers();
}
```

### *3*

- a
    
    Viewport este regiunea din zona utilizatorului a ferestrei pentru care este utilizata
    desenarea zonei de scena din OpenGL.
    
    Metoda mapeaza pur si simplu zona scenei la o regiune a ferestrei.
    

- b
    
    FPS - reprezinta numarul de cadre (imagini) afisate pe ecran intr-o secunda.
    
    Este frecventa cu care OpenGL deseneaza cadrele, emitand o scena dinamica.
    
- c
    Metoda OnUpdateFrame() este rulata in cadrul unui ciclu principal de randare. Ea poate fi folosita la calcularea miscarii obiectelor,coliziilor lor, prelucrarea datelor de intrare de la utilizator.
- d
    
    Modul imediat de randare este o tehnica de desenare a scenei, unde geometria, parametrii obiectelor grafice sunt trimise direct in pipeline-ul grafic la ececutia fiecarui cadru
    

- e
    
    Ultima versiune OpenGL care accepta modul imediat este 3.0
    
- f
    
    Metoda OnRenderFrame() este apelata in ciclul de randare, unde afiseaza pe ecran grafica calculata, actualizata in metoda OnUpdateFrame(). Deci, e apelata dupa executia metodei OnUpdateFrame()
    
- g
    
    Metoda OnResize() trebuie sa fie executata cel putin o data deoarece ea seteaza dimensiunea metodei Viewport(), ce defineste fereastra in care este desenata scena. La fel, e folosita pentru a pastra corect proprtiile scenei la schimbarea dimensiunii ferestrei.
    
- h
    
    Parametrii metodei  CreatePerspectiveFieldOfView() sunt :
    
    FOV - Unghiul de deschidere a campului vizual pe verticala : 0.1 -  π
    
    Aspect Ratio - Raportul dintre latimea si lungimea ferestrei : >0
    
    Near Plane - Distanta minima de la camera pana la planul apropiat : >0
    
    Far Plane - Distanta maxima pana la planul indepartat : >0
    
    Doar obiectele ce vor fi pozitionate intre Near Plane si Far Plane vor fi vizibile. Restul entitatilor vor fi ignorate.