using ICities;

namespace UnlockAllMod
{

    public class UnlockAll : IUserMod
    {

        public string Name
        {
            get { return "Unlock All"; }
        }

        public string Description
        {
            get { return "Progression milestones are always unlocked"; }
        }

    }

    public class UnlockAllMilestones : MilestonesExtensionBase
    {

        public override void OnRefreshMilestones()
        {
            milestonesManager.UnlockMilestone("Basic Road Created");

            if (managers.application.SupportsExpansion(Expansion.Parks))
            {
                milestonesManager.UnlockMilestone("Park Gate Requirements");
                milestonesManager.UnlockMilestone("City Park Requirements 1");
                milestonesManager.UnlockMilestone("City Park Requirements 2");
                milestonesManager.UnlockMilestone("City Park Requirements 3");
                milestonesManager.UnlockMilestone("City Park Requirements 4");
                milestonesManager.UnlockMilestone("City Park Requirements 5");
                milestonesManager.UnlockMilestone("Amusement Park Requirements 1");
                milestonesManager.UnlockMilestone("Amusement Park Requirements 2");
                milestonesManager.UnlockMilestone("Amusement Park Requirements 3");
                milestonesManager.UnlockMilestone("Amusement Park Requirements 4");
                milestonesManager.UnlockMilestone("Amusement Park Requirements 5");
                milestonesManager.UnlockMilestone("Nature Reserve Requirements 1");
                milestonesManager.UnlockMilestone("Nature Reserve Requirements 2");
                milestonesManager.UnlockMilestone("Nature Reserve Requirements 3");
                milestonesManager.UnlockMilestone("Nature Reserve Requirements 4");
                milestonesManager.UnlockMilestone("Nature Reserve Requirements 5");
                milestonesManager.UnlockMilestone("Zoo Requirements 1");
                milestonesManager.UnlockMilestone("Zoo Requirements 2");
                milestonesManager.UnlockMilestone("Zoo Requirements 3");
                milestonesManager.UnlockMilestone("Zoo Requirements 4");
                milestonesManager.UnlockMilestone("Zoo Requirements 5");
            }

            if (managers.application.SupportsExpansion(Expansion.Industry))
            {
                milestonesManager.UnlockMilestone("Main Building Requirements");
                milestonesManager.UnlockMilestone("Farming Requirements 1");
                milestonesManager.UnlockMilestone("Farming Requirements 2");
                milestonesManager.UnlockMilestone("Farming Requirements 3");
                milestonesManager.UnlockMilestone("Farming Requirements 4");
                milestonesManager.UnlockMilestone("Farming Requirements 5");
                milestonesManager.UnlockMilestone("Forestry Requirements 1");
                milestonesManager.UnlockMilestone("Forestry Requirements 2");
                milestonesManager.UnlockMilestone("Forestry Requirements 3");
                milestonesManager.UnlockMilestone("Forestry Requirements 4");
                milestonesManager.UnlockMilestone("Forestry Requirements 5");
                milestonesManager.UnlockMilestone("Oil Requirements 1");
                milestonesManager.UnlockMilestone("Oil Requirements 2");
                milestonesManager.UnlockMilestone("Oil Requirements 3");
                milestonesManager.UnlockMilestone("Oil Requirements 4");
                milestonesManager.UnlockMilestone("Oil Requirements 5");
                milestonesManager.UnlockMilestone("Ore Requirements 1");
                milestonesManager.UnlockMilestone("Ore Requirements 2");
                milestonesManager.UnlockMilestone("Ore Requirements 3");
                milestonesManager.UnlockMilestone("Ore Requirements 4");
                milestonesManager.UnlockMilestone("Ore Requirements 5");
            }

            if (managers.application.SupportsExpansion(Expansion.Campuses))
            {
                milestonesManager.UnlockMilestone("Campus Main Building Requirements");
                milestonesManager.UnlockMilestone("TradeSchool Requirements 1");
                milestonesManager.UnlockMilestone("TradeSchool Requirements 2");
                milestonesManager.UnlockMilestone("TradeSchool Requirements 3");
                milestonesManager.UnlockMilestone("TradeSchool Requirements 4");
                milestonesManager.UnlockMilestone("TradeSchool Requirements 5");
                milestonesManager.UnlockMilestone("LiberalArts Requirements 1");
                milestonesManager.UnlockMilestone("LiberalArts Requirements 2");
                milestonesManager.UnlockMilestone("LiberalArts Requirements 3");
                milestonesManager.UnlockMilestone("LiberalArts Requirements 4");
                milestonesManager.UnlockMilestone("LiberalArts Requirements 5");
                milestonesManager.UnlockMilestone("University Requirements 1");
                milestonesManager.UnlockMilestone("University Requirements 2");
                milestonesManager.UnlockMilestone("University Requirements 3");
                milestonesManager.UnlockMilestone("University Requirements 4");
                milestonesManager.UnlockMilestone("University Requirements 5");
            }

            if (managers.application.SupportsExpansion(Expansion.Urban))
            {
                milestonesManager.UnlockMilestone("Fishing Boat Harbor 02 Requirements");
                milestonesManager.UnlockMilestone("Fishing Boat Harbor 03 Requirements");
                milestonesManager.UnlockMilestone("Fishing Boat Harbor 04 Requirements");
                milestonesManager.UnlockMilestone("Fishing Boat Harbor 05 Requirements");
                milestonesManager.UnlockMilestone("Fish Farm 02 Requirements");
                milestonesManager.UnlockMilestone("Fish Farm 03 Requirements");
                milestonesManager.UnlockMilestone("Seafood Factory Requirements");
            }

            if (managers.application.SupportsExpansion(Expansion.Airport))
            {
                milestonesManager.UnlockMilestone("Airport Requirements 1");
                milestonesManager.UnlockMilestone("Airport Requirements 2");
                milestonesManager.UnlockMilestone("Airport Requirements 3");
                milestonesManager.UnlockMilestone("Airport Terminal Requirements");
            }

            if (managers.application.SupportsExpansion(Expansion.PlazasAndPromenades))
            {
                milestonesManager.UnlockMilestone("Pedestrian Zone Created");
                milestonesManager.UnlockMilestone("Service Point Created");
                milestonesManager.UnlockMilestone("Flower Plaza Reqs");
                milestonesManager.UnlockMilestone("Large Fountain Plaza Reqs");
                milestonesManager.UnlockMilestone("Large PedArea Plaza Reqs");
                milestonesManager.UnlockMilestone("First SP Requirements");
                milestonesManager.UnlockMilestone("Large Cargo SP Reqs");
                milestonesManager.UnlockMilestone("Large Garbage SP Reqs");
                milestonesManager.UnlockMilestone("Large Service Point Reqs");
                milestonesManager.UnlockMilestone("Small Cargo SP Reqs");
                milestonesManager.UnlockMilestone("Small Garbage SP Reqs");
                milestonesManager.UnlockMilestone("Landmark Market Hall Reqs");
                milestonesManager.UnlockMilestone("Landmark MOPMA Reqs");
                milestonesManager.UnlockMilestone("Landmark Shopping Mall Reqs");
                milestonesManager.UnlockMilestone("Landmark Commercial");
                milestonesManager.UnlockMilestone("Landmark Office");
                milestonesManager.UnlockMilestone("Landmark Residential");
            }

            if (managers.application.SupportsExpansion(Expansion.FinanceExpansion))
            {
                milestonesManager.UnlockMilestone("Stock Exchange Level 1 Created");
                milestonesManager.UnlockMilestone("Stock Exchange Level 2 Created");
                milestonesManager.UnlockMilestone("Stock Exchange Level 3 Created");
                milestonesManager.UnlockMilestone("Stock Exchange Level 4 Created");
                milestonesManager.UnlockMilestone("Stock Exchange Level 5 Created");
            }

            if (managers.application.SupportsExpansion(Expansion.Hotels))
            {
                milestonesManager.UnlockMilestone("2-Star Average Popularity");
                milestonesManager.UnlockMilestone("2-Star Hotel");
                milestonesManager.UnlockMilestone("2-Star Hotel Pofit");
                milestonesManager.UnlockMilestone("3-Star Average Popularity");
                milestonesManager.UnlockMilestone("3-Star Hotel");
                milestonesManager.UnlockMilestone("3-Star Hotel Pofit");
                milestonesManager.UnlockMilestone("4-Star Average Popularity");
                milestonesManager.UnlockMilestone("4-Star Hotel");
                milestonesManager.UnlockMilestone("4-Star Hotel Pofit");
                milestonesManager.UnlockMilestone("5-Star Average Popularity");
                milestonesManager.UnlockMilestone("5-Star Hotel");
                milestonesManager.UnlockMilestone("5-Star Hotel Pofit");
            }
        }

        public override int OnGetPopulationTarget(int originalTarget, int scaledTarget)
        {
            return 0;
        }
    }
}
