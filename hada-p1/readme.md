Jose Vallino García

Práctica 1: Uso de Git

P1/ ¿Qué crees que significa la opción -n en el comando revert?
	Significa que al eliminar un commit no efectúa otro automáticamente al finalizar la operación, ha de hacerse manualmente.

P2/	¿Qué cambios se han producido al ejecutar el comando reset?
	Ha borrado el anterior commit y ha devuelto el documento "readme.txt".

P3/	¿Qué diferencias observas entre revert y reset?
	La principal diferencia entre uno y otro es que revert crea otro commit a partir de un commit específico con las características de este último, sin embargo reset 
	restablece el historial hasta llegar al commit deseado.

P4/ ¿Qué diferencias observas entre merge y rebase?
    Se observa que rebase unifica las dos ramas en una, mientras que merge mantiene las ramas separadas pero unidas. Rebase monta los commit encima de la otra rama sin tener en cuenta la cronología,
    merge mantiene el historial tal y como lo teníamos añadiendo un nuevo commit por la unificación.