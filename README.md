# Breve descripcion
Esta aplicación fue desarrollada para el cobro por caja de una tienda vendedora de productos de viveros.
Permite emitir reportes sobre ventas y la facturacion de la compra
Contiene los siguientes roles de usuarios:

Administrador - Gerente - Supervisor - Vendedor 

## Metodologia Agile, Scrum
## Trabajo colaborativo 2 desarrolladores.

# Especificación de Requisitos de Software:

Gestión de Usuarios
RF1: El sistema debe permitir el inicio de sesión de un usuario.
RF2: El sistema debe permitir el alta de un usuario nuevo.
RF3: El sistema debe permitir ver el listado de usuarios.
RF4: El sistema debe permitir modificar un usuario.
RF5: El sistema debe permitir dar de baja un usuario.
RF6: El sistema debe permitir volver a dar de alta a un usuario dado de baja
RF7: El sistema debe permitir cerrar sesión a un usuario.
RF8: El sistema debe permitir realizar búsquedas de usuarios y mostrar los resultados al usuario administrador

Gestión de Navegación
RF9: El sistema debe permitir a cada tipo de usuario (vendedor, administrador, gerente supervisor y supervisor) navegar por formularios exclusivos para su tipo de usuario.
RF10: El sistema debe permitir al usuario ver un listado de Productos.
RF11: El sistema debe permitir ver al usuario un listado de Categorías de Productos.
RF12: El sistema debe permitir al usuario seleccionar un producto y ver descripción del elemento seleccionado.
RF13: El sistema debe permitir al usuario confirmar la selección de productos.
RF14: El sistema debe identificar a través de todo el sistema, cuando sea necesario, al usuario que inició sesión.
RF15: El sistema debe permitir al usuario (gerente supervisor) ver el listado de facturas emitidas
RF16: El sistema debe permitir a cada usuario vendedor ver el listado de las facturas emitidas por el mismo.
RF17: El sistema debe informar con mensajes textuales cada acción que realiza el usuario
RF18: El sistema debe contener búsquedas numerales o textuales representativas en cada tabla de datos visible de la aplicación
RF19: El sistema debe verificar que el usuario no ingrese datos existentes en el sistema para evitar una duplicación de información

Gestión de Stock
RF20: El sistema debe permitir al usuario supervisor visualizar el reporte de stock de productos a través de un gráfico y una tabla representativa.
RF21: El sistema debe permitir al usuario supervisor dar de alta un producto 
RF22: El sistema debe permitir al usuario supervisor dar de alta una categoría de productos
RF23: El sistema debe permitir al usuario supervisor modificar un producto
RF24: El sistema debe permitir al usuario supervisor modificar una categoría de productos.
RF25: El sistema debe permitir al usuario supervisor dar de baja un producto
RF26: El sistema debe permitir al usuario supervisor dar de baja una categoría de productos
RF27: El sistema debe permitir al usuario supervisor dar de alta un producto que fue dado de baja
RF28: El sistema debe permitir al usuario supervisor dar de alta una categoría de productos que fue dada de baja.
RF29: El sistema debe permitir realizar búsquedas de productos y mostrar los resultados al usuario
RF30: El sistema debe permitir realizar búsquedas de categorías y mostrar los resultados al usuario

Gestión de Clientes
RF31: El sistema debe permitir ver el listado de clientes
RF32: El sistema debe permitir dar de alta un cliente
RF33: El sistema debe permitir modificar un cliente
RF34: El sistema debe permitir dar de baja un cliente
RF35: El sistema debe permitir dar de alta un cliente dado de baja
RF36: El sistema debe permitir realizar búsquedas de clientes y mostrar los resultados al usuario
Gestión de Archivos
RF37: El sistema debe almacenar en un soporte físico toda la información ingresada por el usuario y generada por el mismo sistema.
RF38: El sistema debe realizar una copia de seguridad de los datos de la empresa cuando el usuario administrador lo desee.

Gestión de Facturación
RF39: El sistema debe permitir seleccionar productos a un listado.
RF40: El sistema debe permitir seleccionar un medio de pago y cargar datos de un cliente al momento de agregar un producto al listado.
RF41: El sistema debe permitir eliminar productos seleccionados.
RF42: El sistema debe permitir cancelar un producto seleccionado.
RF43: El sistema debe permitir cancelar la compra antes de ser confirmada.
RF44: El sistema no debe permitir efectuar la venta de un producto sin stock.
RF45: El sistema no debe permitir efectuar la venta de un producto cuya cantidad establecida supere el stock existente.
RF46: El sistema debe permitir confirmar la compra e inmediatamente mostrar en pantalla la factura emitida.
RF47: El sistema debe permitir la impresión de la factura emitida.
RF48: El sistema debe permitir que una factura sea exportada en formato PDF.
RF49: El sistema debe permitir realizar búsquedas de facturas y mostrar los resultados al usuario 
RF50: El sistema debe permitir imprimir o exportar en PDF una factura mostrada como resultado de una búsqueda
RF51: El sistema debe permitir visualizar todas las facturas al gerente supervisor.
RF52: El sistema debe permitir visualizar solo las facturas emitidas por el mismo al vendedor.

Reportes
RF53: El sistema debe mostrar un reporte grafico en pantalla al usuario supervisor sobre el stock de los productos.
RF54: El sistema debe mostrar un reporte gráfico en pantalla de la cantidad de ingresos por vendedor al usuario gerente supervisor
RF55: El sistema debe mostrar un reporte grafico en pantalla de los productos más vendidos al usuario gerente supervisor.
