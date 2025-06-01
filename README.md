# BusinessApplication
Beispiel von Youtube, bei dem View und Logik getrennt werden. Logik ist dabei als separates Projekt eingebunden
https://www.youtube.com/watch?v=UPHry14bqvc. Titel: Weg mit der monolitischen Projektstruktur: So trennst Du Dein C#-Projekte richtig.
![grafik](https://github.com/user-attachments/assets/ad11c6a6-9f90-4487-94da-71f4523134a3)

url für Webservice ist unter 'System Variables' eingetragen. Variable = API_URL, Value = https://jsonplaceholder.typicode.com/todos/1

Der DataAccessLayer wird mit File==> NewProject==> "WPF Class Library" erzeugt.
Der DataAccessLayer wird folgendermaßen eingefügt: Im solution explore rechter Mausclick auf BusinessApplication ==> Add ==> ProjectReference ==> DataAccessLayer==>OK

