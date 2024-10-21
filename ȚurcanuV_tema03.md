# Tema 03

1.a

Antiorar. Comentand desenarea axei X, dispare linia din dreapta. Comentand desenarea axei y dispare linia de sus

1.b 

Rezolvare:

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
3. 

7.a

Un gradient este o tranzitie usoara intre 2 sau mai multe culori

7.b

De exemplu creand un triunghi, si dandu-i punctelor sale diferite culori

Rezolvare:

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

Ex 10

Se aplica gradientul, ca si la ex 7.b