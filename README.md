# Breve descripcion
Esta aplicación fue desarrollada para el cobro por caja de una tienda vendedora de productos de viveros.
Permite emitir reportes sobre ventas y la facturacion de la compra
Contiene los siguientes roles de usuarios:

Administrador - Gerente - Supervisor - Vendedor 

## Metodologia Agile, Scrum
## Trabajo colaborativo 2 desarrolladores.

# Especificación de Requisitos de Software:

3.1 Requerimientos Funcionales
Gestión de Usuarios
RF#1: El sistema debe permitir el inicio de sesión de un usuario.
RF#2: El sistema debe permitir el alta de un usuario nuevo.
RF#3: El sistema debe permitir ver el listado de usuarios.
RF#4: El sistema debe permitir modificar un usuario.
RF#5: El sistema debe permitir dar de baja un usuario.
RF#6: El sistema debe permitir volver a dar de alta a un usuario dado de baja
RF#7: El sistema debe permitir cerrar sesión a un usuario.
RF#8: El sistema debe permitir realizar búsquedas de usuarios y mostrar los resultados al usuario administrador

Gestión de Navegación
RF#9: El sistema debe permitir a cada tipo de usuario (vendedor, administrador, gerente supervisor y supervisor) navegar por formularios exclusivos para su tipo de usuario.
RF#10: El sistema debe permitir al usuario ver un listado de Productos.
RF#11: El sistema debe permitir ver al usuario un listado de Categorías de Productos.
RF#12: El sistema debe permitir al usuario seleccionar un producto y ver descripción del elemento seleccionado.
RF#13: El sistema debe permitir al usuario confirmar la selección de productos.
RF#14: El sistema debe identificar a través de todo el sistema, cuando sea necesario, al usuario que inició sesión.
RF#15: El sistema debe permitir al usuario (gerente supervisor) ver el listado de facturas emitidas
RF#16: El sistema debe permitir a cada usuario vendedor ver el listado de las facturas emitidas por el mismo.
RF#17: El sistema debe informar con mensajes textuales cada acción que realiza el usuario
RF#18: El sistema debe contener búsquedas numerales o textuales representativas en cada tabla de datos visible de la aplicación
RF#19: El sistema debe verificar que el usuario no ingrese datos existentes en el sistema para evitar una duplicación de información

Gestión de Stock
RF#20: El sistema debe permitir al usuario supervisor visualizar el reporte de stock de productos a través de un gráfico y una tabla representativa.
RF#21: El sistema debe permitir al usuario supervisor dar de alta un producto 
RF#22: El sistema debe permitir al usuario supervisor dar de alta una categoría de productos
RF#23: El sistema debe permitir al usuario supervisor modificar un producto
RF#24: El sistema debe permitir al usuario supervisor modificar una categoría de productos.
RF#25: El sistema debe permitir al usuario supervisor dar de baja un producto
RF#26: El sistema debe permitir al usuario supervisor dar de baja una categoría de productos
RF#27: El sistema debe permitir al usuario supervisor dar de alta un producto que fue dado de baja
RF#28: El sistema debe permitir al usuario supervisor dar de alta una categoría de productos que fue dada de baja.
RF#29: El sistema debe permitir realizar búsquedas de productos y mostrar los resultados al usuario
RF#30: El sistema debe permitir realizar búsquedas de categorías y mostrar los resultados al usuario


Gestión de Clientes
RF#31: El sistema debe permitir ver el listado de clientes
RF#32: El sistema debe permitir dar de alta un cliente
RF#33: El sistema debe permitir modificar un cliente
RF#34: El sistema debe permitir dar de baja un cliente
RF#35: El sistema debe permitir dar de alta un cliente dado de baja
RF#36: El sistema debe permitir realizar búsquedas de clientes y mostrar los resultados al usuario
Gestión de Archivos
RF#37: El sistema debe almacenar en un soporte físico toda la información ingresada por el usuario y generada por el mismo sistema.
RF#38: El sistema debe realizar una copia de seguridad de los datos de la empresa cuando el usuario administrador lo desee.

Gestión de Facturación
RF#39: El sistema debe permitir seleccionar productos a un listado.
RF#40: El sistema debe permitir seleccionar un medio de pago y cargar datos de un cliente al momento de agregar un producto al listado.
RF#41: El sistema debe permitir eliminar productos seleccionados.
RF#42: El sistema debe permitir cancelar un producto seleccionado.
RF#43: El sistema debe permitir cancelar la compra antes de ser confirmada.
RF#44: El sistema no debe permitir efectuar la venta de un producto sin stock.
RF#45: El sistema no debe permitir efectuar la venta de un producto cuya cantidad establecida supere el stock existente.
RF#46: El sistema debe permitir confirmar la compra e inmediatamente mostrar en pantalla la factura emitida.
RF#47: El sistema debe permitir la impresión de la factura emitida.
RF#48: El sistema debe permitir que una factura sea exportada en formato PDF.
RF#49: El sistema debe permitir realizar búsquedas de facturas y mostrar los resultados al usuario 
RF#50: El sistema debe permitir imprimir o exportar en PDF una factura mostrada como resultado de una búsqueda
RF#51: El sistema debe permitir visualizar todas las facturas al gerente supervisor.
RF#52: El sistema debe permitir visualizar solo las facturas emitidas por el mismo al vendedor.

Reportes
RF#53: El sistema debe mostrar un reporte grafico en pantalla al usuario supervisor sobre el stock de los productos.
RF#54: El sistema debe mostrar un reporte gráfico en pantalla de la cantidad de ingresos por vendedor al usuario gerente supervisor
RF#55: El sistema debe mostrar un reporte grafico en pantalla de los productos más vendidos al usuario gerente supervisor.

