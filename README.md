<h1 align = "center">Unity Extension Method</h1>

[![Made with Unity](https://img.shields.io/badge/Made%20with-Unity-57b9d3.svg?style=flat&logo=unity)](https://unity3d.com) ![GitHub contributors](https://img.shields.io/github/contributors/fallenblood7080/Unity-Extension-Method) ![GitHub forks](https://img.shields.io/github/forks/fallenblood7080/Unity-Extension-Method) ![GitHub Repo stars](https://img.shields.io/github/stars/fallenblood7080/Unity-Extension-Method)





## Table of Content

 - 📃 [Could you tell me what's going on with this project? Why should I Care?](#Could-you-tell-me-whats-going-on-with-this-project-Why-should-I-Care)
 - ⌨ [How do I dive in and get started?](#how-do-i-dive-in-and-get-started)
 - ⁉ [Where can I turn for help if I'm stuck?](#where-can-i-turn-for-help-if-im-stuck)
 




## Could you tell me what's going on with this project? Why should I Care?

To answer this question, first understand what the Extension method is.

> Extension methods enable you to "add" methods to existing types
> without creating a new derived type, recompiling, or otherwise
> modifying the original type. Extension methods are static methods, but
> they're called as if they were instance methods on the extended type.
> [Copied from Microsoft docs](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods)

In simpler words, this thing allows you to extend the functionality of the existing type.
We allow string type containing many methods like ToUpper() or ToLower() to convert the string in upper and lower case respectively, but if I want to create a method which converts the string into title case (*making the first letter of each word upper case*)?
You can go with a traditional approach like creating a method then do this: 
```cs
newText = TitleCase(oldtext);
```
now this code looks out of place if we compare it with `newText = oldText.ToUpper()` or `newText = oldText.ToLower()`, so to deal with things we can use the extensions method which will make the code look like this:
```cs
newText = oldText.ToTitleCase()
```



**So How will I create it?**
Well in the first place, you do not have to that's why this repo exists, all you need put this repo inside your unity project and just call the method like this `something.DoSomethingMoreAwesome()`

**Here are the few Examples of Extension Method that are provided by this repo**
```cs
audioSource.PlayFadeIn(fadeDuration:2,EaseType.EaseIn); //Plays the audio with 2 sec fade in with ease in effect.
```
```cs
explosionPoint.Add2DExplosiveForce(5, 10, explosionLayer); //Add the 2D Explosion Force of 10 unit force with the radius of 5 units which will impact the object in explosionLayer at explosionPoint(Vector2)
```

```cs
someRandomList.GetRandomItem(2); //get 2 random items from the someRandomList
```

## How do I dive in and get started?
Just Download the package from [Release](https://github.com/fallenblood7080/Unity-Extension-Method/releases) and import it in unity and you are done! 
________________

## Where can I turn for help if I'm stuck?
Feeling a bit stuck and need some friendly advice? No worries, we've got your back! Just swing by our [Discussion Page on GitHub](https://github.com/fallenblood7080/Unity-Extension-Method/discussions).

### Contributors
<a href="https://github.com/fallenblood7080/Unity-Extension-Method/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=fallenblood7080/Unity-Extension-Method" />
</a>
<br><br><br>

Here is the [Contribution Guide](https://github.com/fallenblood7080/Unity-Extension-Method/wiki/Contributions)
