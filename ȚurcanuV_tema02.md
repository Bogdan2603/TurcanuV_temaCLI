1.a

**Antiorar**. Comentand desenarea axei X, dispare linia dindreapta. Comentand desenarea axei y dispare linia de sus



1.b **Rezolvare**:
```csharp
private voidDrawAxes() {

    GL.Begin(PrimitiveType.Lines);

    GL.Color3(Color.Red);

    GL.Vertex3(0, 0, 0);

    GL.Vertex3(XYZ\_SIZE, 0, 0);

  GL.Color3(Color.Yellow);

 GL.Vertex3(0, 0, 0);

 GL.Vertex3(0, XYZ\_SIZE, 0);

GL.Color3(Color.Green);

GL.Vertex3(0, 0, 0);

GL.Vertex3(0, 0,XYZ\_SIZE);

GL.End();

}
```
2\. Anti-aliasingfuncționează prin adăugarea de pixeli gri de-a lungul marginii unei linii saucurbe pentru a se amesteca cu culoarea de fundal. Acest proces de amestecarereduce vizibilitatea marginilor zimțate, astfel încât acestea par mai fine șimai puțin vizibile.

3.a

Se modifica grosimea liniilor desenate

3.b

Se modifica grosimea punctelor desenate

3.c

Nu.  MetodaGL.begin()  aplica setarile tuturorentitatilor care au fost declarate inaintea inceperii executarii sale

4\. a

LineLoop deseneaza linii care conectează toate punctelesuccesive într-o buclă, unde ultima linie conecteaza ultimul punct cu primul.

4\. b

LineStrip are functia asemanatoare cu LineLoop, unicadiferenta fiind neconectarea primului si ultimului punct printr-o linie.

4.c

TriangleFan folosește primul punct specificat capunct central, iar toate celelalte puncte formează triunghiuri conectate laacest punct central. Fiecare punct nou va avea ca puncta commune primul punctcentral, si punctul precedent.

4.d

TriangleStrip conectează punctele specificate (minimum 3)pentru a forma o bandă continuă de triunghiuri, unde fiecare nou punct,împreună cu cele două puncte anterioare, formează un triunghi.

6.

1\. Distingerea usoara a mai multor entitati

2\. Simularea efectelor de lumina si umbra

7.a

Un gradient este o tranzitie usoara intre 2 sau mai multeculori

7.b

De exemplu creand un triunghi, si dandu-i punctelor salediferite culori

**Rezolvare**:
```csharp

private void DrawAxes() {

//  Triangle withGradient

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
Ex 10

Se aplica gradientul, ca si la ex 7.b