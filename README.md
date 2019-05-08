# SimpleMVVM
SimpleMVVM (as the name implies) framework is a simple and light implementation of the MVVM pattern. It started as learning process into the MVVM pattern but over time I've come to reuse of the components over and over. Hence, the rise of the framework.

## Contributions
Currently, I am not accepting (nor expecting) any contributors. But if you want to help I would greatly appreciate feedbacks and bugs. To file abug please open an Issue. Alternatively you can clone the repo and initiate a pull request.


## Status
The project is in progress, still in it's beta and not yet reliable.

## Usage

### Commands
SimpleMVVM has its own implementation of relay command that can be used to separate UI components from the logic that needs to be executed on command invocation. This enables testing of business logic separately while ensuring that the UI code is loosely coupled to business logic. SimpleMVVM's implentation of relay command takes two delagtes as parameters, the first executes the required logic and the other is a predicate to determines if a command is enabled or disabled.
    
    bool EnableCommandDelegate()
    {
        return true; // some logic that will determin the state of the command
    }

    void OpenWorkbookExecute()
    {
        // do command logic here
    }

    var command = new RelayCommand(CommandDelegate, EnableCommandDelegate);

You can then use the command in a view

    <MenuItem Header="Open" Command="{Binding OpenCommand}" />

### IOC
SimpleMVVM bundles its own IOC container, an instance of which is accessible via a static accessor ``IocContainer.Instance``. For the container to be able to resolve a service, an interface of the service and implementation has to be registered with IOC container prior to a resolve request. See example below

    // Register a file service
    IocContainer.Instance.Register<IFileService, FtpFileService>();

    // get an instance of the file service
    var fileService = IocContainer.Instance.Resolve<IFileService>();


## TODO
+ Dynamically locate viewmodel for view and vice versa (base on some convention).
+ Dynamically bind control to properties based the names assigned to the controls.
+ Determin what the convention above will be.

## Issue Reporting

If you have found a bug or if you have a feature request, please report them at this repository issues section.

## Author

[Yemi Kudaisi](https://github.com/yemikudaisi)

## License

This project is licensed under the MIT license. See the [LICENSE](LICENSE) file for more info.