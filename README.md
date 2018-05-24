# ASP .NET MVC 5

Agenda:
1. Fundamentals
2. Building Forms
3. Implementing Validation
4. Web API

## Fundamentals

RouteConfig: routes of MVC  
Controllers:  
Views:  
Models: domain objects  
ActionResults, ViewResults  
Action Parameters  
Convention-based Routing  
Attribute Routing  
Passing Data to Views  
View Models  
Razor  
Partial Views  

## Building Forms
BeginForm LabelFor  TextboxFor  
Labels  
Drop-down Lists  
Model Binding  
Edit Form   

## Implementing Validation 
Validation

Styling Validations   
Data Annotations  
Custom Validation  
Validation Summary  
Client-side Validation   
Anti-forgery Tokens   

## Web API
RESTful  
APIController  
Camel Notation  
IHttpActionResult   
SPAs

```

table {
    border-collapse: collapse;
}

td {
    border: 5px solid #000;
    width: 100px;
    height: 100px;
    line-height: 100px;
    text-align: center;
    font-size: 50pt;
}

```

```
<table>
    <tr>
        <td id="0">X</td>
        <td id="1">O</td>
        <td id="2">@Model.Grid[0, 2]</td>
    </tr>
    <tr>
        <td id="3">@Model.Grid[1, 0]</td>
        <td id="4">@Model.Grid[1, 1]</td>
        <td id="5">@Model.Grid[1, 2]</td>
    </tr>
    <tr>
        <td id="6">@Model.Grid[2, 0]</td>
        <td id="7">@Model.Grid[2, 1]</td>
        <td id="8">@Model.Grid[2, 2]</td>
    </tr>
</table>
````