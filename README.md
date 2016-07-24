# radian-android
Radian is a single-player, infinite-platformer style mobile game published on the Google Play Store in July, 2016.

### Its features include:
>  Industry unique, innovative gameplay.
> Easy to understand controls.
>  Classic, arcade feel.
>  Colorful graphics.
>  Facebook SDK implementation
> Google Admob plugin implementation

### Development
This is my first project, and improvements to making code cleaner, following better C# coding practices, have been made in my future projects.

Radian was created with the Unity2D Engine, scripted in C#.
The game uses a variety of licensed assets, most of which have been listed below. The first build of Radian had issues running on several Android devices, particularly because pause screen's canvas was not set up to scale to different resolutions. Secondly, the number of batches and setpass calls had to be decreased in order to reduce the amount of stuttering and low frame rate, that was determined to be a result of excess mipmap generation, the presence of too many sprites on the same scene, and uncompressed audio. This issue was dealt with by switching off mipmap generation, organizing sprites in different canvases, and compressing audio respectively; a stable frame rate was achieved in the final build, which has received overwhelmingly positive reviews - with an average rating of 5 stars - on the Google Play Store. The organization of the files could be further organized by dealing with obstacle looping in ```ObsLooper.cs``` using camera coordinates in an ```internal struct```. 

The game was finally ported for use on Android devices, although an unpublished iOS build (.ipa) is available.

### Facebook SDK
Radian implements the Facebook SDK in order to to share score, invite friends, and like the Facebook page. The initialization and requests of which are dealt with in ```FBScript.cs```
### Admob Plugin
The Unity Admob plugin from Google was installed and interstital and banner ads were displayed using ```menuStateManager.cs ``` and ```AdManager.cs```
### Assets
Sprites from the following sources were used
>http://kenney.nl/assets

>http://www.gameart2d.com/free-sci-fi-platformer-tileset.html

### Google Play
>https://play.google.com/store/apps/details?id=com.neurondev.radian

### Authors
>Abhishek S. Tumuluru

>Mohit Chauhan
### Updated Version
1.0.4
