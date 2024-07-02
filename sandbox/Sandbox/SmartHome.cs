using System;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Net;
using System.Text.Json.Serialization;

abstract class SmartHome
{
    bool deviceOn = false;
    public virtual bool DeviceStatus(bool deviceOn)
    {
        return deviceOn;
    }
    

    public virtual bool DeviceSwitch(bool deviceOn)
    {
        if(deviceOn == true)
        {
            return deviceOn = false;
        }
        else
        {
            return deviceOn = true;
        }
    }

    public virtual int UseTimer(bool deviceOn)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        // creates loop while the device is on
        while(deviceOn == true)
        {
        
        }
        // creates finished value when it finishes
        if (deviceOn == false)
        {
            stopwatch.Stop();
        }

        int timeOn = Convert.ToInt32(stopwatch.Elapsed.Seconds);
        return timeOn;
    }
}