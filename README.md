

Respuestas

String en C# es un tipo por referencia y no tiene un tamaño determinado. Los tipos de datos por referencia se alojan en el heap por lo que la gestion de memoria que ocupan es mas compleja, y el uso de los datos es menos eficiente que los tipos por valor.

Las secuencias de escape del tipo String son:
\a	Campana (alerta)
\b	Retroceso
\f	Avance de página
\n	Nueva línea
\r	Retorno de carro
\t	Tabulación horizontal
\v	Tabulación vertical
\'	Comilla simple
\"	Comillas dobles
\\	Barra diagonal inversa
\?	Signo de interrogación literal
\ooo	Carácter ASCII en notación octal
\xhh	Carácter ASCII en notación hexadecimal
\xhhhh	Carácter Unicode en notación hexadecimal si esta secuencia de escape se utiliza en una constante de caracteres anchos o un literal de cadena Unicode.


El caracter @ antes de una cadena de texto la define como una cadena literal, o sea no tiene en cuenta las secuencias de escape.

A su vez el caracter $ antes de la cadena, la identifica como cadena interpolada. La interpolación de cadenas proporciona una sintaxis mas legible y conveniente de dar formato a las cadenas.
Dentro de estas cadenas se puede incluir expresiones y funciones, que se reemplazaran por los resultados.


