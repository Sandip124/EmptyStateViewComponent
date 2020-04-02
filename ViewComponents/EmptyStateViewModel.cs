namespace EmptyState.ViewComponents
{
    public class EmptyStateViewModel
    {
        public string message { get; set; } = "Result is empty.";
        public string controllerName { get; set; }
        public string actionName { get; set; } = "create";
        public string buttonClass { get; set; } = "btn btn-primary btn-sm";
        public string buttonIcon { get; set; } = "fa fa-plus fa-md";
        public string buttonText { get; set; } = "Add";
    }
}