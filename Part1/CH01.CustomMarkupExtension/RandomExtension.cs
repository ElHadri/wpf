using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Threading;

namespace CH01.CustomMarkupExtension
{
    public class RandomExtension : MarkupExtension
    {
        // PROPERTIES
        readonly int _from;
        readonly int _to;
        static readonly Random _rnd = new Random();   
        public bool UseFractions { get; set; } /* property injection (provide fractional values and not just integral ones) */       
        public TimeSpan UpdateInterval { get; set; } /* modifying the property value at a regular interval */

        // CTORs
        public RandomExtension(int from, int to)
        {
            _from = from;
            _to = to;
        }
        public RandomExtension(int to) : this(0, to)
        {
        }

        // METHOD
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            // int value = _rnd.Next(_from, _to);

            Type targetType = null;
            DependencyProperty dp = null;
            PropertyInfo clrProp = null;
            object targetObject = null;


            //------------------------------------------------------------------------
            /*(provide fractional values and not just integral ones)*/
            double value = UseFractions ?
                _rnd.NextDouble() * (_to - _from) + _from :
                (double)_rnd.Next(_from, _to);


            if (serviceProvider != null)
            {
                var target = serviceProvider.GetService(typeof(IProvideValueTarget)) as IProvideValueTarget;
                if (target != null)
                {
                    targetObject = target.TargetObject;

                    clrProp = target.TargetProperty as PropertyInfo;

                    if (clrProp != null)
                        targetType = clrProp.PropertyType;

                    if (targetType == null)
                    {
                        dp = target.TargetProperty as DependencyProperty;
                        if (dp != null)
                            targetType = dp.PropertyType;
                    }
                }
            }

            object finalValue = targetType != null ?
                Convert.ChangeType(value, targetType) :
                value.ToString();

            //------------------------------------------------------------------------
            if (UpdateInterval != TimeSpan.Zero)
            {
                /* setup timer */
                var timer = new DispatcherTimer();
                timer.Interval = UpdateInterval;

                /* start timer */
                timer.Start();

                // run after each interval !!
                timer.Tick += (sender, e) =>
                {
                    // écraser
                    value = UseFractions ?
                    _rnd.NextDouble() * (_to - _from) + _from :
                    (double)_rnd.Next(_from, _to);

                    // écraser
                    finalValue = targetType != null ?
                    Convert.ChangeType(value, targetType) :
                    value.ToString();

                    if (dp != null)
                        ((DependencyObject)targetObject).SetValue(dp, finalValue);
                    else if (clrProp != null)
                        clrProp.SetValue(targetObject, value, null);
                };
            }
            //------------------------------------------------------------------------


            return finalValue;

            //return targetType != null ? 
            //    Convert.ChangeType(value, targetType) : 
            //    value.ToString();

            //return (double)_rnd.Next(_from, _to);
        }
    }
}
