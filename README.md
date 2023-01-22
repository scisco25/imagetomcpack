# imagetomcpack
![Screenshot of UI](https://github.com/scisco25/imagetomcpack/blob/master/UI.png?raw=true)
This Tool Is Not Affliated With Or Approved By Minecraft, Mojang, or Microsoft In Any Way

# So what is it?
imagetomcpack is a tool writen in C# winforms for creating a resource pack that turns a singular image into every single texture in the game.

# how does it work?
On startup it finds all game versions with a assosiated .jar in your versions directory. Then during creation it gets a list of all .png files from the selected .jar and creates a resource pack by creating a folder skeleton and filling all the places that .pngs where in the .jar. then it compresses it into a zip with a pack.mcmeta and allows you to load it in game.

# why?
why not.
