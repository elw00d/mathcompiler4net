﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ELW.Library.Math;
using ELW.Library.Math.Exceptions;
using ELW.Library.Math.Expressions;
using ELW.Library.Math.Tools;

namespace ExampleApp {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e) {
            try {
                // Compiling an expression
                PreparedExpression preparedExpression = ToolsHelper.Parser.Parse(textBoxExpression.Text);
                CompiledExpression compiledExpression = ToolsHelper.Compiler.Compile(preparedExpression);
                // Optimizing an expression
                CompiledExpression optimizedExpression = ToolsHelper.Optimizer.Optimize(compiledExpression);
                // Creating list of variables specified
                List<VariableValue> variables = new List<VariableValue>();

                double firstValue;
                if (!Double.TryParse(textBoxValue1.Text, out firstValue)) {
                    MessageBox.Show("Error converting first variable value.");
                    return;
                }
                variables.Add(new VariableValue(firstValue, textBoxVariable1.Text));

                double secondValue;
                if (!Double.TryParse(textBoxValue2.Text, out secondValue)) {
                    MessageBox.Show("Error converting second variable value.");
                    return;
                }
                variables.Add(new VariableValue(secondValue, textBoxVariable2.Text));

                // Do it !
                double res = ToolsHelper.Calculator.Calculate(compiledExpression, variables);
                // Show the result.
                MessageBox.Show(String.Format("Result: {0}\nOptimized: {1}", res, ToolsHelper.Decompiler.Decompile(optimizedExpression)));
            } catch (CompilerSyntaxException ex) {
                MessageBox.Show(String.Format("Compiler syntax error: {0}", ex.Message));
            } catch (MathProcessorException ex) {
                MessageBox.Show(String.Format("Error: {0}", ex.Message));
            } catch (ArgumentException) {
                MessageBox.Show("Error in input data.");
            } catch (Exception) {
                MessageBox.Show("Unexpected exception.");
                throw;
            }
        }
    }
}
