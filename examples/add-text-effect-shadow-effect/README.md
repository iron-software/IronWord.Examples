***Based on <https://ironsoftware.com/examples/add-text-effect-shadow-effect/>***

Adding a shadow effect to text in a Word document can be easily accomplished in just a few lines of code. To show this process from start to finish, we first initialize a new `WordDocument` instance named `doc`. Next, we create a `TextStyle` object and apply a shadow effect by setting the `Shadow.OuterShadow1` static named instance to the `TextEffect` property of this `TextStyle`. The phrase "Hello World" is then inserted into the document using the newly configured `textStyle`. To finish, the Word document is exported.

For additional examples and demonstrations, please refer to the following article: [How to Add Shadow Effect to Text](https://ironsoftware.com/csharp/word/how-to/text-effect-shadow-effect/).