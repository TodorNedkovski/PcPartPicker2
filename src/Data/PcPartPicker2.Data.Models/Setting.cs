namespace PcPartPicker2.Data.Models
{
    using PcPartPicker2.Data.Common.Models;

    public class Setting : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }
}
