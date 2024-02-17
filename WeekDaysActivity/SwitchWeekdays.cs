using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeekdays : MonoBehaviour
{
    public WeekDays weekDays;


    // Start is called before the first frame update
    void Start()
    {
        switch(weekDays)
        {
            case WeekDays.Monday: Debug.Log("Today is Monday"); break;
            case WeekDays.Tuesday: Debug.Log("Today is Tuesday"); break;
            case WeekDays.Wednesday: Debug.Log("Today is Wednesday"); break;
            case WeekDays.Thursday: Debug.Log("Today is Thursday"); break;
            case WeekDays.Friday: Debug.Log("Today is Friday"); break;
            case WeekDays.Saturday: Debug.Log("Today is Saturday"); break;
            case WeekDays.Sunday: Debug.Log("Today is Sunday"); break;
            default: Debug.Log("It is not a week"); break;
        }
    }
}
