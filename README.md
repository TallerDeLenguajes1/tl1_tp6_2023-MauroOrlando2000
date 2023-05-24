# tl1_tp6_2023-MauroOrlando2000
tl1_tp6_2023-MauroOrlando2000 created by GitHub Classroom
\
### ¿String es una tipo por valor o un tipo por referencia?
El String es un tipo por referencia ya que se almacena en el heap en lugar del stack. Al crearlo se crea una referencia a un objeto almacenado en el heap.
\
### ¿Qué secuencias de escape tiene el tipo string?
\'  Comilla simple\
\"  Comilla doble\
\\  Barra invertida\
\0  null\
\b  Retroceso\
\n  Nueva línea\
\t  Tabulación horizontal\
\v  Tabulación vertical\
\
### ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
El @ antes de un string hace que todo lo que antes se interpretaba como una secuencia de escape sea ignorado y escriba literalmente lo que está almacenado.
El $ antes de un string permite ingresar variables dentro de la cadena misma, facilitando el mantenimiento de esta. La variable que se quiere ingresar debe estar escrita en llaves ("{}").
