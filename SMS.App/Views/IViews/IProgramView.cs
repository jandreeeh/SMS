namespace SMS.App.Views.IViews
{
    public interface IProgramView
    {
        string Description { get; set; }
        int ProgramId { get; set; }
        string ProgramName { get; set; }

        void GetProgramList(BindingSource bindingSource);
    }
}