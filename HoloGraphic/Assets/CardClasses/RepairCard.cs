public class RepairCard : BaseCard
{
    public void createRepairCard(string name, int lvl, int ram, int action, int durationValue, int targetValue, int xpValue, string description, string details)
    {
        setCardName(name);
        setLevel(lvl);
        setRamCost(ram);
        setActionValue(action);
        setDuration(durationValue);
        setTarget(targetValue);
        setXP(xpValue);
        setBackendDescription(description);
        setIconDetails(details);
    }
}
