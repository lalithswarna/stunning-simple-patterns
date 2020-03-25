namespace Pattern4Repository{

    interface IRepository<T>{
        void Add(T i);
        void Remove(T i);
        string GetAll();
    }

}