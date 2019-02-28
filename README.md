# TPF-Taller
Trabajo Práctico Final 

## Introducción
El trabajo práctico final consta de la realización de una aplicación para una terminal autoservicio o kiosco bancario. 
Una terminal de autoservicio o kiosco es un equipo informático situado en lugar público que permite a los usuarios realizar múltiples acciones. También se utiliza como herramienta de información y marketing para las empresas. En la actualidad, los kioscos interactivos a menudo tienen pantallas táctiles. Tienen como objetivo presentar una interfaz amistosa y de fácil interacción que facilite su utilización por cualquier tipo de usuario. Se utilizan en muchas aplicaciones y mercados verticales, tales como bancos, ventas de entradas de espectáculos, correos, hospitales, aeropuertos, estaciones ferroviarias, grandes supermercados. etcétera.
La aplicación deberá ser capaz de identificar al cliente, presentándole diferentes opciones de operaciones a realizar una vez identificado. La aplicación interactuará con una API de servicios del core bancario de la institución, con el fin de delegar las ejecuciones de las operaciones seleccionadas. Básicamente la aplicación es una orquestador de acceso a servicios.

## Requerimientos No Funcionales

### Identificación del cliente
La primera pantalla en presentarse al usuario es la de identificación de cliente. En la misma el usuario debe introducir su número de DNI y la contraseña numérica de home banking de cuatro dígitos para proseguir con el flujo. Una vez capturados esos datos se deberá validar el usuario mediante el Servicio S1. De haber algún problema con la validación se debe presentar una pantalla de error al usuario con información relevante. De ser exitosa la validación, el sistema pasa a la siguiente etapa de presentación de operaciones. 

### Operaciones
En esta pantalla se le presentarán al usuario las operaciones que podrá acceder el usuario ya validado por la terminal de autoservicio. Las mismas serán los siguientes: 
> Blanqueo de PIN 

El objetivo de la operación es permitir seleccionar y blanquear el PIN de una de las tarjetas pertenecientes al usuario, tanto de las que es titular como de las que son extensiones. En primera medida el sistema deberá acceder al Servicio S2 para obtener los productos que el cliente posee en la entidad bancaria. La aplicación deberá presentar como opciones a seleccionar los números de tarjeta y al ser seleccionado uno, el sistema deberá acceder al Servicio S3, el cual procederá a blanquear el PIN de la tarjeta elegida.

> Saldo de cuenta corriente 
El objetivo de este servicio es mostrar al usuario el saldo que posee de la cuenta corriente del cliente en la institución.
El sistema deberá acceder al Servicio S4 el cual devolverá la información de saldos del
cliente. Se deberá presentar dicha información al usuario para su conocimiento. 

> Últimos movimientos 
Este servicio visualizará al usuario los últimos movimientos de su cuenta bancaria. Para ello el sistema deberá interactuar con el Servicio S5 que devuelve los últimos movimientos de una cuenta de un cliente de la institución.

### Flujo general
La aplicación deberá guiar al usuario para realizar las operaciones que requiere, con un formato de pantalla tipo asistente. Ante cualquier error se debe presentar una pantalla describiendo el mismo para su comprensión por el usuario.

### Registro de operaciones 
El sistema deberá registrar en una Base de Datos todas las acciones que realiza un cliente con la terminal de autoservicio para su posterior análisis. La información que se debe persistir no debe contener datos sensibles, como por ejemplo clave de home banking, saldos, entre otros. Se deberá registrar también el tiempo insumido en la ejecución de las operaciones de la API. La explotación de la información persistida queda fuera del alcance de este requerimiento.
El registro de los datos no debe interferir con la operatoria normal de la aplicación. De mediar algún problema con el acceso al servidor de Base de Datos en el momento del registro, se prefiere obviar dicha persistencia antes que falle el servicio.



