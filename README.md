# Formulario de Windows con .NET y C#

## Un formulario de Windows en .NET con C# es una interfaz gráfica de usuario basado en controles,  propiedades y eventos que puedes crear utilizando la tecnología Windows Forms (WinForms).
![Resources/formulario.png](resources/formulario.png) 

- En este repositorio realizo un formulario para calcular el interés compuesto usando la formula M=(1+r%)^t × C ; donde:

Donde:
- ( M ) es el monto futuro o valor acumulado después de ( t ) períodos.
- ( C ) es el valor presente o principal.
- ( r%) es la tasa de interés por período, expresada como un porcentaje.
- ( t ) es el número de períodos.

```csharp
    //Tienes un capital inicial (valor presente) de $1,000 y estás invirtiendo en una cuenta de ahorros que paga el 5% de interés anual. Quieres calcular cuánto tendrás al cabo de 3 años.

    M = (1+0.05)^3 × 1000

    M = (1.05)^3 * 1000 

    M = (1.157625) * 1000 = $1,157.625

```
 ![Resources/formulario.png](resources/formulario2.png) 

 - El botón **Calcular** tiene el evento click asociado y la lógica que aplica la fórmula, el botón **Nuevo** permite vaciar los controles de entrada conocidos como TextBox y botón **Salir** unicamente tiene un método asociado para cerrar la aplicación *Close().*

 ```csharp
 //Botón Calcular
private void btncalcular_Click(object sender, EventArgs e)
        {   
            //Declaración de variables
            double capital, razon, tiempo;
            double interes, monto;

            //Capturando la entrada de los datos
            capital = double.Parse(txtcapital.Text);
            razon = double.Parse(txtrazon.Text);
            tiempo = double.Parse(txttiempo.Text);

            //Proceso de datos
            monto = Math.Pow((1+razon), tiempo) * capital;
            interes = monto - capital;

            //Salida de Información
            txtmontofinal.Text= $"$ {Convert.ToString(monto)}";
            txttotalinteres.Text = $"$ {Convert.ToString(interes)}";
             
        }

        //Botón Nuevo

        private void btnnuevo_Click_1(object sender, EventArgs e)
        {
            LimpiarControles(this.Controls);
        }
  

        private void LimpiarControles(Control.ControlCollection controles)
        {
            foreach (Control control in controles)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                
                if (control.HasChildren)
                {
                    LimpiarControles(control.Controls);
                }
            }
        }

        //Botón Salir
         private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

```


![logo](resources/logo.png)

- **Nombre:** Engels Cárcamo
- **Correo Electrónico:** engelscarcamo59@gmail.com
- **Sitio Web:** [engelscarcamo.com](https://engelscarcamo.netlify.app)
- **Teléfono:** +505 (75049820)


