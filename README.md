# ?? Commitments Contract Reading Tool

Una herramienta de escritorio en Windows Forms para calcular ajustes contractuales de forma precisa y r�pida. Ideal para contratistas, contadores y profesionales que trabajan con contratos, change orders y pagos pendientes en ERP.

---

## ?? Funcionalidades

- Ingreso r�pido de datos clave del contrato:
  - Suma original del contrato
  - Cambio neto por change orders
  - Total de nuevos change orders
  - Facturas pendientes en ERP
  - Contrato revisado (actual)

- C�lculos autom�ticos:
  - Suma revisada del contrato
  - Diferencia entre lo calculado y lo declarado
  - Monto a ajustar en facturas

- Formateo num�rico autom�tico con separadores y decimales.
- Colores visuales para facilitar lectura y revisi�n.
- Bot�n de **Reset** para limpiar todos los campos al instante.

---

## ?? Tecnolog�as usadas

- **.NET (Windows Forms)**
- Lenguaje: **C#**
- Framework compatible: `.NET 6.0+` o `.NET Framework 4.8`
- UI Cl�sica WinForms, liviana y directa.

---

## ?? L�gica de C�lculo

La f�rmula central se basa en dos reglas principales:

1. Si `NetChange < 0` y `TotalChangeOrders > 0`, entonces el ajuste es igual a `TotalChangeOrders`.
2. Si hay una diferencia negativa entre el contrato revisado y el valor calculado, se ajusta restando lo pendiente en ERP.

---

??? Modo desarrollo

1. Clona el repositorio:

git clone https://github.com/tuusuario/ContractReadingToolApp.git
cd ContractReadingToolApp

2. Abre el archivo .sln en Visual Studio
3. Aseg�rate de seleccionar la configuraci�n Debug o Release
4. Ejecuta con F5 o compila con Ctrl + Shift + B

?? Contribuciones
�Quieres ayudar? �Perfecto! Sigue estos pasos:

1. Haz un fork del proyecto:
git clone https://github.com/tuusuario/ContractReadingToolApp.git

2. Crea una nueva rama:
git checkout -b feature/mi-mejora

3. Realiza tus cambios y haz commit:
git commit -m "Agrega nueva funcionalidad"