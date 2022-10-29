using UnityEngine;
public class BaseCard : ScriptableObject
{
    [SerializeField] public string cardName;
    [SerializeField] public int level, ramCost, actionValue, duration, target, xp;
    [SerializeField] public string backendDescription, iconDetails;

    public BaseCard()
    {
        cardName = backendDescription = iconDetails = string.Empty;
        level = ramCost = actionValue = duration = target = xp = 0;
    }

    //setters
    protected void setCardName(string name){  cardName = name;    }
    protected void setLevel(int lvl)    { level = lvl;    }
    protected void setRamCost(int ram)    {   ramCost = ram;    }
    protected void setActionValue(int action)    {    actionValue = action;    }
    protected void setDuration(int durationValue)    {    duration = durationValue;    }
    protected void setTarget(int targetValue)    {    target = targetValue;    }
    protected void setXP(int xpValue) {   xp = xpValue;   }
    protected void setBackendDescription(string description) { backendDescription = string.Copy(description);   }
    protected void setIconDetails(string details) { iconDetails = string.Copy(details);    }

    //getters
    public string getCardName() { return cardName; }
    public int getLevel() { return level; }
    public int setRamCost() { return ramCost; }
    public int getActionValue() { return actionValue; }
    public int getDuration() { return duration; }
    public int getTarget() { return target; }
    public int getXP() { return xp; }
    public string getBackendDescription() { return backendDescription; }
    public string getIconDetails() { return iconDetails; }
}
