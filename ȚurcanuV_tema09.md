# ȚurcanuV_tema09

1. Descrieti diferentele dintre iluminarea asa cum functioneaza in lumea reala si modelul de iluminare utilizat de OpenGL.
    - În lumea reală, iluminarea este complicată, cu reflexii, refracții și dispersii multiple, fiecare foton influențând scena. În OpenGL, lucrurile sunt simplificate, folosind modele precum Phong sau, care redau doar reflexii ambientale, difuze și speculare, fără să calculeze tot traseul luminii.

---

1. Cate surse de lumina sunt suportate in implementarea curenta a OpenGL cu ajutorul framework-ului OpenTK?
    - OpenGL suporta cel putin 8 surse de lumina

---

1. Definiti iluminarea de material si specificati unde si cand este utilizata aceasta.
    - Iluminarea materialelor se referă la efectele de lumină incluse în textura sau materialul unui obiect 3D. De exemplu, un material emisiv pare că luminează singur. Acest efect se folosește pentru a crea LED-uri, obiecte strălucitoare sau pentru a face scenele mai realiste.

---

1. Care este efectul asupra diverselor obiecte la activarea unei surse de lumina secundare (per pct.  comparativ cu utilizarea unei singure surse de lumina?
- Creează umbre suplimentare, iluminare mai diversificată și reflexii mai naturale, făcând obiectele să pară mai tridimensionale.  Cu o singură sursă de lumină, scena poate părea plată și simplistă.