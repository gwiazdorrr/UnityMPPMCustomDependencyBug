## Steps to reproduce

1. Open the project
2. Open `Window/Multiplayer Play Mode`
3. Check `Player 2`, wait for it to launch
4. Notice there are no errors in the console
5. Reimport `Assets/MyScriptedAsset.foo` - notice there are no errors in the consle
6. Select `Bug/Update Custom Dependency` - notice `Asset Database is set to Read Only, but it has found out-of-date assets. This should not happen!` in the virtual client's console.
