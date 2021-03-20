namespace CH07.CookbookMVVM
{

    //----------------------------------------------------------------------------------
    public abstract class ViewModelBase : ObservableObject
    {
    }
    //----------------------------------------------------------------------------------
    public abstract class ViewModelBase<TModel> : ViewModelBase
    {
        private TModel _model;
        public TModel Model
        {
            get { return _model; }
            set { SetProperty(ref _model, value); }
        }
    }
    //----------------------------------------------------------------------------------
    /*  Undo/redo operations typically span multiple ViewModels. We'll add the ability to link ViewModels in a parent-child relationship, if needed*/
    public abstract class ViewModelBase<TModel, TParentVM> : ViewModelBase<TModel>
    {
        public TParentVM Parent { get; set; }

        public ViewModelBase(TModel model = default(TModel), TParentVM parentVM = default(TParentVM))
        {
            Model = model;
            Parent = parentVM;
        }
    }
}