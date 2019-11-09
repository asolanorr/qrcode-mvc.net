# qrcode-mvc.net

VIDEO: https://youtu.be/hjhXyjnWYsY

Implementación de librerías de JavaScript en un proyecto de ASP.NET.

Un código QR es un código de barras bidimensional cuadrada que puede almacenar los datos codificados. La mayoría del tiempo los datos es un enlace a un sitio web (URL). Un código QR (del inglés Quick Response code, "código de respuesta rápida") es la evolución del código de barras. Es un módulo para almacenar información en una matriz de puntos o en un código de barras bidimensional. La matriz se lee en el dispositivo móvil por un lector específico (lector de QR) y de forma inmediata nos lleva a una aplicación en internet y puede ser un mapa de localización, un correo electrónico, una página web o un perfil en una red social. Fue creado en 1994 por la compañía japonesa Denso Wave, subsidiaria de Toyota. Presenta tres cuadrados en las esquinas que permiten detectar la posición del código al lector. El objetivo de los creadores (un equipo de dos personas en Denso Wave, dirigido por Masahiro Hara) fue que el código permitiera que su contenido se leyera a alta velocidad. Los códigos QR son muy comunes en Japón, donde son el código bidimensional más popular. 

En esta investigación veremos cómo crear y leer códigos QR utilizando ASP.NET, el modelo vista controlador (MVC) y unas librerías de javascript.

Las librerías que vamos a usar están disponibles en Github, la primera es la encargada de crear los códigos QR y se llama “qrcode.js” (https://github.com/davidshimjs/qrcodejs). La segunda librería que utilizaremos sera “instascan” (https://github.com/schmich/instascan) esta es la encargada de leer los códigos con nuestra webcam. Ambas son gratuitas y no hay problemas con licencias siempre y cuando sean de uso personal.

Para empezar vamos a crear nuestra solución y proyecto en Visual Studio, dentro de la solución vamos a crear un proyecto de tipo “ASP.NET Web Application (.NET Framework)” de c#.

Esto nos creará casi todo nuestra arquitectura que utilizaremos para el frontend.
Vamos a personalizarla un poco y añadir y eliminar algunos archivos tales como, el tema de bootstrap (opcional), aunque cabe destacar que hacer esto es completamente opcional y no afecta a la aplicación de ninguna manera.

Archivos y carpetas agregados:

Carpetas “Controls” y “Helpers” dentro de “Models”.
Carpeta “Views” dentro de “Scripts”.
Librerías dentro de “Scripts”, qrcode.min.js y instascan.min.js



Archivos y carpetas eliminados:

Estilos dentro de la carpeta “Content”, se elimina todo excepto el bootstrap.min.css y el site.css ambos son opcionales, si se quiere aplicar un tema personalizado se puede sustituir el archivo bootstrap.min.css, dentro de site.css se quita un padding-top del body.
Todos los scripts de la carpeta “Scripts” excepto bootstrap.min.js y jquery-3.3.1.min.js.
Vistas “About” y “Contact” dentro de Views/Home.

Una vez hecho todo esto vamos a crear todos los “Controllers” de nuestro frontend, desde el principal padre de todos “CtrlBaseModel” hasta cada elemento que será utilizado en la app. En este caso vamos a crear un controller para: inputs, botones, la caja donde se mostrará el QR creado, el video que se mostrará de nuestra webcam. Recuerden que todos los ejemplos de cada controller está en el zip que deje en la descripción del video.

Creamos el archivo ControlExtensions.cs dentro de la carpeta “Helpers” y agregamos todos los métodos que obtendrán el html de cada control.

Ahora podemos ver un poco de JavaScript, dentro de “Scripts/Views”, podemos crear un script por cada ventana que vamos a crear, en este caso van a ser solo dos, Index.js (Crear), y ReadQR.js (Leer).

En el repositorio de Github de cada librería hay ejemplos de código para ejecutar estas acciones, en este caso voy a utilizar el de cada librería con ligeras modificaciones que podrán ver en la solución del video.

Una vez hayamos creado los scripts, podemos ir a las vistas y utilizar nuestros “Controls”, dentro Index.cshtml (nuestra vista para crear) vamos a agregar tres elementos: un input para que el usuario digite lo que desee convertir en QR, un botón para ejecutar la acción y una caja (div) para que se vea el resultado del QR. No podemos olvidarnos de llamar los siguientes archivos: 
 @using WebUI.Models.Helpers;
 <script src=”~/Scripts/Views/Index.js”></script>
El layout.

Del mismo modo con ReadQR.cshtml vamos a crearlo y agregar el script correspondiente como el ejemplo del video. Con su control de video “CtrlVideoModel” y su script debajo.

Hecho una vez todo esto y seguido paso a paso el video, debe correr perfectamente la aplicación.

FUENTES: 

https://github.com/davidshimjs/qrcodejs
https://github.com/schmich/instascan
https://es.wikipedia.org/wiki/C%C3%B3digo_QR
