# fault-reporting-system
El sistema cumple la función de administrar reportes de averías, pretende ser multipropósito, por lo que puede utilizarse tanto para administrar
las averías de un ISP como también soporte técnico en cualquier ámbito.
Consta de dos partes, una sección para que los clientes generen un reporte y otra para que los administradores puedan revisarlas.

## Tabla de contenidos (incompleta)
- [Instalación](#instalación)
- [Funcionamiento](#funcionamiento)
  - [Interfaz gráfica](#interfaz-gráfica)
  - [Clases](#clases)
  - [Conexión a base de datos](#conexión-a-base-de-datos)
 
## Instalación
lorem ipsum

## Funcionamiento

### Interfaz gráfica
El proyecto se elabora con C# utilizando WPF, el diseño de las ventanas, por lo tanto, se crea utilizando XAML.

Para lograr el efecto de insertar las vistas dentro de la ventana principal (**/WPF/MainWindow.xaml**), se utilizan dos clases espciales: 

  - **/Core/RelayCommand.cs**

  - **/Core/ObservableObject.cs**.

Las Views que se muestran en el **/WPF/MainWindow.xaml** se encuentran en la carpeta */MVVM/View/*, por cada una de ellas existe una clase que le representa en la carpeta 
*/MVVM/ViewModel/*.
Este diseño ViewModel conecta los *view.xaml* con su clase *viewModel.cs* respectiva y permite a la clase **/MVVM/Model/mainViewModel.cs/** lograr el efecto deseado.
Con este diseño, se logra la fluidez en el efecto de cambiar de vista al apretar botones en el menú derecho sin tener que abrir una ventana nueva.

En la carpeta Themes se encuentran los diccionarios de recursos para aplicar estilos personalizados a los objetos de las ventanas, (botones, cajas de texto, etc)

### Clases
En la carpeta */src/* se encuentran las clases principales del proyecto, que cumplen la función de manejar datos reflejados en la base de datos, además de
implementar funciones que realizan validaciones.

Sin miedo aquí Alti.

### Conexión a Base de Datos
Sin miedo aquí Fausto.
