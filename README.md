AddSingleton() - As the name implies, AddSingleton() method creates a Singleton service. A Singleton service is created when it is first requested whether it is in the scope of same http request or across different http requests. This same instance is then used by all the subsequent requests. So in general, a Singleton service is created only one time per application and that single instance is used throughout the application life time.

AddTransient() - This method creates a Transient service. A new instance of a Transient service is created each time it is requested.

AddScoped() - This method creates a Scoped service. A new instance of a Scoped service is created once per request within the scope. For example, in a web application it creates 1 instance per each http request but uses the same instance in the other calls within that same web request.
Use scoped if service is used for inter service communication for the same request. (e.g. in case of parallel processing for coordination/progress/state etc.)
Use transient otherwise.
