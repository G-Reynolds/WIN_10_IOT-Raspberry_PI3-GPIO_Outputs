using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.Devices.Gpio;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PI3_GPIO_test_outputs
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private const int GPIO02 = 2;  // GPIO-02 <> pin 03
        private const int GPIO03 = 3;  // GPIO-03 <> pin 05
        private const int GPIO04 = 4;  // GPIO-04 <> pin 07
        private const int GPIO05 = 5;  // GPIO-05 <> pin 29
        private const int GPIO06 = 6;  // GPIO-06 <> pin 31
        private const int GPIO07 = 7;  // GPIO-07 <> pin 26
        private const int GPIO08 = 8;  // GPIO-08 <> pin 24
        private const int GPIO09 = 9;  // GPIO-09 <> pin 21
        private const int GPIO10 = 10; // GPIO-10 <> pin 19
        private const int GPIO11 = 11; // GPIO-11 <> pin 23
        private const int GPIO12 = 12; // GPIO-12 <> pin 32
        private const int GPIO13 = 13; // GPIO-13 <> pin 33
        private const int GPIO16 = 16; // GPIO-16 <> pin 36
        private const int GPIO17 = 17; // GPIO-17 <> pin 11
        private const int GPIO18 = 18; // GPIO-18 <> pin 12
        private const int GPIO19 = 19; // GPIO-19 <> pin 35
        private const int GPIO20 = 20; // GPIO-20 <> pin 38
        private const int GPIO21 = 21; // GPIO-21 <> pin 40
        private const int GPIO22 = 22; // GPIO-22 <> pin 15
        private const int GPIO23 = 23; // GPIO-23 <> pin 16
        private const int GPIO24 = 24; // GPIO-24 <> pin 18
        private const int GPIO25 = 25; // GPIO-25 <> pin 22
        private const int GPIO26 = 26; // GPIO-26 <> pin 37
        private const int GPIO27 = 27; // GPIO-27 <> pin 13

        //
        private GpioPin Pin_3;
        private GpioPin Pin_5;
        private GpioPin Pin_7;
        private GpioPin Pin_29;
        private GpioPin Pin_31;
        private GpioPin Pin_26;
        private GpioPin Pin_24;
        private GpioPin Pin_21;
        private GpioPin Pin_19;
        private GpioPin Pin_23;
        private GpioPin Pin_32;
        private GpioPin Pin_33;
        private GpioPin Pin_36;
        private GpioPin Pin_11;
        private GpioPin Pin_12;
        private GpioPin Pin_35;
        private GpioPin Pin_38;
        private GpioPin Pin_40;
        private GpioPin Pin_15;
        private GpioPin Pin_16;
        private GpioPin Pin_18;
        private GpioPin Pin_22;
        private GpioPin Pin_37;
        private GpioPin Pin_13;


        private GpioPinValue pinValue;

        private SolidColorBrush redBrush = new SolidColorBrush(Windows.UI.Colors.Red);
        private SolidColorBrush greenBrush = new SolidColorBrush(Windows.UI.Colors.Green);



        public MainPage()
        {
            this.InitializeComponent();
            InitGPIO();

        }


        private void InitGPIO()
        {
            var gpio = GpioController.GetDefault();

            // Show an error if there is no GPIO controller
            if (gpio == null)
            {
                GPIO.Text = "There is no GPIO controller on this device.";

                //disable buttons as no gpio controller, example run on local Machine PC, (not raspberry pi 3)
                //
                GPIO_02.IsEnabled = false;
                GPIO_03.IsEnabled = false;
                GPIO_04.IsEnabled = false;
                GPIO_05.IsEnabled = false;
                GPIO_06.IsEnabled = false;
                GPIO_07.IsEnabled = false;
                GPIO_08.IsEnabled = false;
                GPIO_09.IsEnabled = false;
                GPIO_10.IsEnabled = false;
                GPIO_11.IsEnabled = false;
                GPIO_12.IsEnabled = false;
                GPIO_13.IsEnabled = false;
                GPIO_16.IsEnabled = false;
                GPIO_17.IsEnabled = false;
                GPIO_18.IsEnabled = false;
                GPIO_19.IsEnabled = false;
                GPIO_20.IsEnabled = false;
                GPIO_21.IsEnabled = false;
                GPIO_22.IsEnabled = false;
                GPIO_23.IsEnabled = false;
                GPIO_24.IsEnabled = false;
                GPIO_25.IsEnabled = false;
                GPIO_26.IsEnabled = false;
                GPIO_27.IsEnabled = false;
                                
                return;
            }

            //set all pins to default value to Low
            //
            //GPIO 02 - PIN 03
            Pin_3 = gpio.OpenPin(GPIO02);
            pinValue = GpioPinValue.Low;
            Pin_3.Write(pinValue);
            Pin_3.SetDriveMode(GpioPinDriveMode.Output);
            
            //GPIO 03 - PIN 05
            Pin_5 = gpio.OpenPin(GPIO03);
            pinValue = GpioPinValue.Low;
            Pin_5.Write(pinValue);
            Pin_5.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 04 - PIN 07
            Pin_7 = gpio.OpenPin(GPIO04);
            pinValue = GpioPinValue.Low;
            Pin_7.Write(pinValue);
            Pin_7.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 05 - PIN 29
            Pin_29 = gpio.OpenPin(GPIO05);
            pinValue = GpioPinValue.Low;
            Pin_29.Write(pinValue);
            Pin_29.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 06 - PIN 31
            Pin_31 = gpio.OpenPin(GPIO06);
            pinValue = GpioPinValue.Low;
            Pin_31.Write(pinValue);
            Pin_31.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 07 - PIN 26
            Pin_26 = gpio.OpenPin(GPIO07);
            pinValue = GpioPinValue.Low;
            Pin_26.Write(pinValue);
            Pin_26.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 08 - PIN 24
            Pin_24 = gpio.OpenPin(GPIO08);
            pinValue = GpioPinValue.Low;
            Pin_24.Write(pinValue);
            Pin_24.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 09 - PIN 21
            Pin_21 = gpio.OpenPin(GPIO09);
            pinValue = GpioPinValue.Low;
            Pin_21.Write(pinValue);
            Pin_21.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 10 - PIN 19
            Pin_19 = gpio.OpenPin(GPIO10);
            pinValue = GpioPinValue.Low;
            Pin_19.Write(pinValue);
            Pin_19.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 11 - PIN 23
            Pin_23 = gpio.OpenPin(GPIO11);
            pinValue = GpioPinValue.Low;
            Pin_23.Write(pinValue);
            Pin_23.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 12 - PIN 32
            Pin_32 = gpio.OpenPin(GPIO12);
            pinValue = GpioPinValue.Low;
            Pin_32.Write(pinValue);
            Pin_32.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 13 - PIN 33
            Pin_33 = gpio.OpenPin(GPIO13);
            pinValue = GpioPinValue.Low;
            Pin_33.Write(pinValue);
            Pin_33.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 16 - PIN 36
            Pin_36 = gpio.OpenPin(GPIO16);
            pinValue = GpioPinValue.Low;
            Pin_36.Write(pinValue);
            Pin_36.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 17 - PIN 11
            Pin_11 = gpio.OpenPin(GPIO17);
            pinValue = GpioPinValue.Low;
            Pin_11.Write(pinValue);
            Pin_11.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 18 - PIN 12
            Pin_12 = gpio.OpenPin(GPIO18);
            pinValue = GpioPinValue.Low;
            Pin_12.Write(pinValue);
            Pin_12.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 19 - PIN 35
            Pin_35 = gpio.OpenPin(GPIO19);
            pinValue = GpioPinValue.Low;
            Pin_35.Write(pinValue);
            Pin_35.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 20 - PIN 38
            Pin_38 = gpio.OpenPin(GPIO20);
            pinValue = GpioPinValue.Low;
            Pin_38.Write(pinValue);
            Pin_38.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 21 - PIN 40
            Pin_40 = gpio.OpenPin(GPIO21);
            pinValue = GpioPinValue.Low;
            Pin_40.Write(pinValue);
            Pin_40.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 22 - PIN 15
            Pin_15 = gpio.OpenPin(GPIO22);
            pinValue = GpioPinValue.Low;
            Pin_15.Write(pinValue);
            Pin_15.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 23 - PIN 16
            Pin_16 = gpio.OpenPin(GPIO23);
            pinValue = GpioPinValue.Low;
            Pin_16.Write(pinValue);
            Pin_16.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 24 - PIN 18
            Pin_18 = gpio.OpenPin(GPIO24);
            pinValue = GpioPinValue.Low;
            Pin_18.Write(pinValue);
            Pin_18.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 25 - PIN 22
            Pin_22 = gpio.OpenPin(GPIO25);
            pinValue = GpioPinValue.Low;
            Pin_22.Write(pinValue);
            Pin_22.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 26 - PIN 37
            Pin_37 = gpio.OpenPin(GPIO26);
            pinValue = GpioPinValue.Low;
            Pin_37.Write(pinValue);
            Pin_37.SetDriveMode(GpioPinDriveMode.Output);

            //GPIO 27 - PIN 13
            Pin_13 = gpio.OpenPin(GPIO27);
            pinValue = GpioPinValue.Low;
            Pin_13.Write(pinValue);
            Pin_13.SetDriveMode(GpioPinDriveMode.Output);
            
            GPIO.Text = "GPIO pins initialized correctly.";
        }

        //toggle pins low or high
        //
        private void GPIO_02_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_3.Write(pinValue);
            LED_pin_3.Fill = redBrush;  // redBrush;
        }

        private void GPIO_02_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_3.Write(pinValue);
            LED_pin_3.Fill = greenBrush;  // greenBrush;
        }

        private void GPIO_03_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_5.Write(pinValue);
            LED_pin_5.Fill = redBrush;
        }

        private void GPIO_03_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_5.Write(pinValue);
            LED_pin_5.Fill = greenBrush;
        }

        private void GPIO_04_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_7.Write(pinValue);
            LED_pin_7.Fill = redBrush;
        }

        private void GPIO_04_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_7.Write(pinValue);
            LED_pin_7.Fill = greenBrush;
        }

        private void GPIO_05_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_29.Write(pinValue);
            LED_pin_29.Fill = redBrush;
        }

        private void GPIO_05_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_29.Write(pinValue);
            LED_pin_29.Fill = greenBrush;
        }

        private void GPIO_06_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_31.Write(pinValue);
            LED_pin_31.Fill = redBrush;
        }

        private void GPIO_06_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_31.Write(pinValue);
            LED_pin_31.Fill = greenBrush;
        }

        private void GPIO_07_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_26.Write(pinValue);
            LED_pin_26.Fill = redBrush;
        }

        private void GPIO_07_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_26.Write(pinValue);
            LED_pin_26.Fill = greenBrush;
        }

        private void GPIO_08_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_24.Write(pinValue);
            LED_pin_24.Fill = redBrush;
        }

        private void GPIO_08_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_24.Write(pinValue);
            LED_pin_24.Fill = greenBrush;
        }

        private void GPIO_09_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_21.Write(pinValue);
            LED_pin_21.Fill = redBrush;
        }

        private void GPIO_09_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_21.Write(pinValue);
            LED_pin_21.Fill = greenBrush;
        }

        private void GPIO_10_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_19.Write(pinValue);
            LED_pin_19.Fill = redBrush;
        }

        private void GPIO_10_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_19.Write(pinValue);
            LED_pin_19.Fill = greenBrush;
        }

        private void GPIO_11_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_23.Write(pinValue);
            LED_pin_23.Fill = redBrush;
        }

        private void GPIO_11_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_23.Write(pinValue);
            LED_pin_23.Fill = greenBrush;
        }

        private void GPIO_12_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_32.Write(pinValue);
            LED_pin_32.Fill = redBrush;
        }

        private void GPIO_12_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_32.Write(pinValue);
            LED_pin_32.Fill = greenBrush;
        }

        private void GPIO_13_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_33.Write(pinValue);
            LED_pin_33.Fill = redBrush;
        }

        private void GPIO_13_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_33.Write(pinValue);
            LED_pin_33.Fill = greenBrush;
        }

        private void GPIO_16_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_36.Write(pinValue);
            LED_pin_36.Fill = redBrush;
        }

        private void GPIO_16_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_36.Write(pinValue);
            LED_pin_36.Fill = greenBrush;
        }

        private void GPIO_17_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_11.Write(pinValue);
            LED_pin_11.Fill = redBrush;
        }

        private void GPIO_17_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_11.Write(pinValue);
            LED_pin_11.Fill = greenBrush;
        }

        private void GPIO_18_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_12.Write(pinValue);
            LED_pin_12.Fill = redBrush;
        }

        private void GPIO_18_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_12.Write(pinValue);
            LED_pin_12.Fill = greenBrush;
        }

        private void GPIO_19_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_35.Write(pinValue);
            LED_pin_35.Fill = redBrush;
        }

        private void GPIO_19_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_35.Write(pinValue);
            LED_pin_35.Fill = greenBrush;
        }

        private void GPIO_20_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_38.Write(pinValue);
            LED_pin_38.Fill = redBrush;
        }

        private void GPIO_20_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_38.Write(pinValue);
            LED_pin_38.Fill = greenBrush;
        }

        private void GPIO_21_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_40.Write(pinValue);
            LED_pin_40.Fill = redBrush;
        }

        private void GPIO_21_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_40.Write(pinValue);
            LED_pin_40.Fill = greenBrush;
        }

        private void GPIO_22_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_15.Write(pinValue);
            LED_pin_15.Fill = redBrush;
        }

        private void GPIO_22_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_15.Write(pinValue);
            LED_pin_15.Fill = greenBrush;
        }

        private void GPIO_23_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_16.Write(pinValue);
            LED_pin_16.Fill = redBrush;
        }

        private void GPIO_23_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_16.Write(pinValue);
            LED_pin_16.Fill = greenBrush;
        }

        private void GPIO_24_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_18.Write(pinValue);
            LED_pin_18.Fill = redBrush;
        }

        private void GPIO_24_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_18.Write(pinValue);
            LED_pin_18.Fill = greenBrush;
        }

        private void GPIO_25_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_22.Write(pinValue);
            LED_pin_22.Fill = redBrush;
        }

        private void GPIO_25_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_22.Write(pinValue);
            LED_pin_22.Fill = greenBrush;
        }

        private void GPIO_26_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_37.Write(pinValue);
            LED_pin_37.Fill = redBrush;
        }

        private void GPIO_26_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_37.Write(pinValue);
            LED_pin_37.Fill = greenBrush;
        }

        private void GPIO_27_Checked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.High;
            Pin_13.Write(pinValue);
            LED_pin_13.Fill = redBrush;
        }

        private void GPIO_27_Unchecked(object sender, RoutedEventArgs e)
        {
            pinValue = GpioPinValue.Low;
            Pin_13.Write(pinValue);
            LED_pin_13.Fill = greenBrush;
        }       
    }
}
