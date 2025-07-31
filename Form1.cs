using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ContractReadingToolApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AttachEventHandlers(); // Asocia eventos a los controles
        }

        // Configura los eventos Leave de los campos de texto y el botón de reset
        private void AttachEventHandlers()
        {
            txtOriginalContractSum.Leave += (s, e) => OnFieldLeave(txtOriginalContractSum);
            txtNetChangeByChangeOrders.Leave += (s, e) => OnFieldLeave(txtNetChangeByChangeOrders);
            txtRevisedContractSumActual.Leave += (s, e) => OnFieldLeave(txtRevisedContractSumActual);
            txtNewTotalChangeOrders.Leave += (s, e) => OnFieldLeave(txtNewTotalChangeOrders);
            txtInvoicesERP.Leave += (s, e) => OnFieldLeave(txtInvoicesERP);

            btnReset.Click += (s, e) => ClearAllFields();
        }

        // Se dispara al salir de un campo: formatea y recalcula
        private void OnFieldLeave(TextBox textBox)
        {
            FormatTextBox(textBox);
            CalculateAllValues();
        }

        // Aplica formato numérico con comas y dos decimales
        private void FormatTextBox(TextBox textBox)
        {
            if (double.TryParse(textBox.Text.Replace(",", ""), out double value))
            {
                string formatted = value.ToString("#,##0.00");
                if (textBox.Text != formatted)
                    textBox.Text = formatted;
            }
        }

        // Ejecuta los cálculos solo si hay algún campo con datos
        private void CalculateAllValues()
        {
            if (AllInputsAreEmpty())
                return;

            // Convertir los textos de entrada a números
            double originalContract = ParseToDouble(txtOriginalContractSum.Text);
            double netChangeOrders = ParseToDouble(txtNetChangeByChangeOrders.Text);
            double revisedContractActual = ParseToDouble(txtRevisedContractSumActual.Text);
            double totalChangeOrders = ParseToDouble(txtNewTotalChangeOrders.Text);
            double pendingInvoicesERP = ParseToDouble(txtInvoicesERP.Text);

            // Ejecutar la lógica del cálculo principal
            var result = CalculateContractMetrics(
                originalContract,
                netChangeOrders,
                revisedContractActual,
                totalChangeOrders,
                pendingInvoicesERP
            );

            // Mostrar los resultados
            txtRevisedContractSumCalculated.Text = result.RevisedSum.ToString("#,##0.00");
            txtDifferencesCalculated.Text = result.Difference.ToString("#,##0.00");
            txtInvoicesAdjustCalculated.Text = result.InvoiceAdjustment.ToString("#,##0.00");
        }

        // Verifica si todos los campos están vacíos
        private bool AllInputsAreEmpty()
        {
            return string.IsNullOrWhiteSpace(txtOriginalContractSum.Text) &&
                   string.IsNullOrWhiteSpace(txtNetChangeByChangeOrders.Text) &&
                   string.IsNullOrWhiteSpace(txtRevisedContractSumActual.Text) &&
                   string.IsNullOrWhiteSpace(txtNewTotalChangeOrders.Text) &&
                   string.IsNullOrWhiteSpace(txtInvoicesERP.Text);
        }

        // Calcula valores: RevisedSum, Difference y InvoiceAdjustment
        private (double RevisedSum, double Difference, double InvoiceAdjustment) CalculateContractMetrics(
            double originalContract,
            double netChangeOrders,
            double revisedContractActual,
            double totalChangeOrders,
            double pendingInvoicesERP)
        {
            double revisedSumCalculated = originalContract + totalChangeOrders;
            double difference = revisedContractActual - revisedSumCalculated;

            double invoiceAdjustment = 0;

            // Caso 1: contrato revisado tiene cambio negativo pero hay órdenes positivas
            if (netChangeOrders < 0 && totalChangeOrders > 0)
                invoiceAdjustment = totalChangeOrders;

            // Caso 2: diferencia negativa → se ajusta descontando lo pendiente en ERP
            else if (difference < 0)
                invoiceAdjustment = -difference - pendingInvoicesERP;

            return (revisedSumCalculated, difference, invoiceAdjustment);
        }

        // Intenta convertir texto a double, devuelve 0 si falla
        private double ParseToDouble(string input)
        {
            if (double.TryParse(input.Replace(",", ""), NumberStyles.Any, CultureInfo.InvariantCulture, out double result))
                return result;

            return 0;
        }

        // Limpia todos los campos de entrada y resultados
        private void ClearAllFields()
        {
            txtOriginalContractSum.Text = "";
            txtNetChangeByChangeOrders.Text = "";
            txtRevisedContractSumActual.Text = "";
            txtNewTotalChangeOrders.Text = "";
            txtInvoicesERP.Text = "";

            txtRevisedContractSumCalculated.Text = "";
            txtDifferencesCalculated.Text = "";
            txtInvoicesAdjustCalculated.Text = "";
        }
    }
}