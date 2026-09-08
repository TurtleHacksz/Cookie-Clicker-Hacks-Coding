# Cookie Clicker Console Cheats Guide

## Table of Contents
- [Basic Console Commands](#basic-console-commands)
- [Cookie & Production Cheats](#-cookie--production-cheats)
- [Achievement & Upgrade Cheats](#-achievement--upgrade-cheats)
- [Building Related Cheats](#-building-related-cheats)
- [Golden Cookie Cheats](#-golden-cookie--effects-cheats)
- [Grandmapocalypse Cheats](#-grandmapocalypse-cheats)
- [Sugar Lump Cheats](#-sugar-lump-cheats)
- [Seasonal & Special Events](#-seasonal--special-events)
- [Game Mechanics Cheats](#-game-mechanics-cheats)
- [Visual & UI Enhancements](#-visual--ui-enhancements)
- [Minigames & Special Features](#-minigames--special-features)
- [Save Manipulation & Data Management](#-save-manipulation)
- [Debug & Special Cheats](#-debug--special-cheats)
- [Important Notes](#-important-notes)
- [Tips for Safe Cheating](#-tips-for-safe-cheating)
- [Useful Links](#-useful-links)

## Basic Console Commands

### Opening the Console
- **Chrome**: Press `Ctrl + Shift + J` (Windows) or `Cmd + Option + J` (Mac)
- **Firefox**: Press `Ctrl + Shift + K` (Windows) or `Cmd + Option + K` (Mac)
- **Edge**: Press `Ctrl + Shift + J`
- **Safari**: Press `Cmd + Option + C`
- **Opera GX**: Press `Ctrl + Shift + C` or right-click and select 'Inspect Element'

### Basic Game Controls

```javascript
// Save game
Game.WriteSave();

// Load save
Game.LoadSave();

// Hard reset game
Game.HardReset();

// Soft reset (Ascend)
Game.Ascend();

// Toggle particles
Game.particles = 0/1;

// Change fps
Game.fps = 30; // Default is 30
```

## 🍪 Cookie & Production Cheats

### Basic Cookie Commands

```javascript
// Set exact cookie amount
Game.cookies = 1000000;

// Add cookies to current amount
Game.Earn(1000000);

// Infinite cookies
Game.cookies = Infinity;

// Divide cookies by 1000
Game.cookies /= 1000;
Game.cookiesEarned /= 1000;

// Set cookies in bank greater than cookies earned (triggers cheated achievement)
Game.cookies = Game.cookiesEarned + 1000000;
```

### Production Modifiers

```javascript
// Change cookies per second
Game.cookiesPs = 1000000;

// Change mouse cookies per click
Game.computedMouseCps = 100000;

// Multiply production by 1000
Game.gainMult = 1000;
```

## 🏆 Achievement & Upgrade Cheats

### Achievement Commands

```javascript
// Unlock all achievements
Game.SetAllAchievs(1);

// Unlock specific achievement
Game.Win('Achievement name');

// Remove specific achievement
Game.Achievements['Achievement name'].won = 0;

// Remove all achievements
Game.AchievementsById.forEach(function(e) {
    e.won = 0;
});

// Check if you have an achievement
Game.Has('Achievement name');
```

### Upgrade Commands

```javascript
// Unlock all upgrades
Game.SetAllUpgrade(1);

// Unlock specific upgrade
Game.Unlock('Upgrade name');

// Buy specific upgrade
Game.Upgrades['Upgrade name'].earn();

// Make all upgrades free
Game.UpgradesById.forEach(function(e) {
    e.basePrice = 0;
});
Game.upgradesToRebuild = 1;

// Remove upgrade
Game.Upgrades['Upgrade name'].bought = 0;
```

## 🏗️ Building Related Cheats

### Building Modifications

```javascript
// Make all buildings free
Game.ObjectsById.forEach(function(e) {
    e.basePrice = 0;
    e.refresh();
});
Game.storeToRebuild = 1;

// Add specific number of buildings
Game.Objects['Cursor'].amount = 100;

// Add 100 of each building
Game.ObjectsById.forEach(obj => obj.amount += 100);

// Keep prices at base price
Game.priceIncrease = 1;

// Change bulk buy amount
Game.buyBulk = 100; // Can be 1, 10, or 100
```

### Building Level Commands

```javascript
// Upgrade building level (sugar lump)
Game.ObjectsById[index].level = amount;
Game.recalculateGains = 1;

// Sacrifice buildings
for (var i in Game.Objects) {
    Game.Objects[i].sacrifice(1);
}
```

## 🌟 Golden Cookie & Effects Cheats

### Golden Cookie Spawning

```javascript
// Spawn basic golden cookie
new Game.shimmer('golden');

// Spawn with specific properties
var newShimmer = new Game.shimmer('golden');
newShimmer.dur = duration;  // Duration
newShimmer.life = life;     // Cookie life
newShimmer.force = 'effect_type';  // Force specific effect
newShimmer.sizeMult = size;  // Size multiplier

// Force wrath cookie
new Game.shimmer('golden').force = 'wrath';

// Spawn multiple cookies
for (var i = 0; i < amount; i++) {
    new Game.shimmer('golden').pop();
}
```

### Golden Cookie Effects

```javascript
// Force specific effects
Game.gainBuff('frenzy', duration, multiplier);
Game.gainBuff('dragon harvest', duration, multiplier);
Game.gainBuff('elder frenzy', duration, multiplier);
Game.gainBuff('clot', duration, multiplier);
Game.gainBuff('click frenzy', duration, multiplier);

// Remove all effects
for (let i in Game.buffs) Game.buffs[i].time = 1;
```

### Auto-Click Features

```javascript
// Click all golden cookies
setInterval(function() {
    Game.shimmers.forEach(function(shimmer) {
        if (shimmer.type == "golden") { shimmer.pop() }
    })
}, 500);

// Click during any buff
setInterval(function() {
    if (Game.hasBuff('any')) Game.ClickCookie();
}, interval);
```

## 👵 Grandmapocalypse Cheats

### Basic Grandmapocalypse Control

```javascript
// Change Elder Pledge time
Game.pledgeT = minutes * 60 * Game.fps;

// Auto-buy Elder Pledge
setInterval(function() {
    if (Game.UpgradesInStore.indexOf(Game.Upgrades["Elder Pledge"]) != -1) {
        Game.Upgrades["Elder Pledge"].buy();
    }
}, 500);

// Change grandmatriarch status
Game.elderWrath = 0; // 0:Appeased, 1:Awoken, 2:Displeased, 3:Angered

// Toggle grandmapocalypse
Game.ToggleGrandmapocalypse();
```

### Wrinkler Management

```javascript
// Spawn all wrinklers
for (i = 0; i < Game.wrinklers.length; i++) {
    Game.wrinklers[i].phase = 1;
}

// Make all wrinklers shiny
for (i = 0; i < Game.wrinklers.length; i++) {
    Game.wrinklers[i].type = 1;
}

// Kill all wrinklers
Game.wrinklers.forEach(me => me.hp = 0);

// Change wrinkler limit
Game.wrinklerLimit = value;
```

## 🍬 Sugar Lump Cheats

```javascript
// Add sugar lumps
Game.lumps = amount;

// Remove sugar lump cooldown
Game.canRefillLump = function() { return true; };

// Change lump type
Game.lumpCurrentType = type; // 0:normal, 1:bifurcated, 2:golden, 3:meaty, 4:caramelized

// Make sugar lumps grow faster
Game.lumpRipeAge = 100; // Default is higher

// Make lumps mature instantly
Game.computeLumpTimes = function() {
    Game.lumpMatureAge = 0;
    Game.lumpRipeAge = 0;
};
```

## 🎃 Seasonal & Special Events

### Holiday Season Control

```javascript
// Enable eternal seasons without heavenly upgrade
Game.Upgrades["Eternal seasons"].earn();

// Unlock season switcher
Game.Upgrades["Season switcher"].earn();

// Force specific season
Game.season = 'christmas'; // Options: christmas, halloween, valentines, easter, fools

// Control season duration
Game.seasonT = duration;
```

### Easter

```javascript
// Unlock all easter eggs
Game.easterEggs.forEach(function(upgrade) {
    Game.Unlock(upgrade);
});

// Force easter egg drops
Game.dropEgg();
```

## 🎮 Game Mechanics Cheats

### Basic Game Controls

```javascript
// Change FPS
Game.fps = 1000;

// Change milk progress
Game.milkProgress = amount;

// Change bakery name
Game.bakeryName = "name";
Game.bakeryNameRefresh();

// Reset game
Game.HardReset();

// Force auto-save
Game.toSave = true;

// Toggle particles
Game.particles = 0/1;
```

### Heavenly Chips & Prestige

```javascript
// Add heavenly chips
Game.heavenlyChips = amount;
Game.CalculatePrestige();

// Change prestige level
Game.prestige = amount;
Game.prestige.ready = 1;
Game.recalculateGains = 1;

// Maximum heavenly chips
Game.cookiesReset = Number.MAX_VALUE;
Game.CalculatePrestige();

// Get all heavenly upgrades
Game.UpgradesById.forEach(function(upgrade) {
    if(upgrade.pool == 'prestige') upgrade.earn();
});
```

## 🎨 Visual & UI Enhancements

### Visual Effects

```javascript
// Toggle particles
Game.particles = 0/1;

// Make game "party mode"
Game.PARTY = true;

// Toggle fancy graphics
Game.prefs.fancy = 1/0;

// Toggle CSS filters
Game.prefs.filters = 1/0;

// Toggle milk display
Game.prefs.milk = 1/0;

// Toggle cursors display
Game.prefs.cursors = 1/0;
```

### Performance Optimization

```javascript
// Reduce animation effects
Game.prefs.fancy = 0;
Game.prefs.particles = 0;

// Disable milk
Game.prefs.milk = 0;

// Disable cursors
Game.prefs.cursors = 0;

// Lower quality rendering
Game.prefs.lowQuality = 1;
```

## 🎲 Minigames & Special Features

### Garden Minigame

```javascript
// Unlock all seeds
Game.Objects['Farm'].minigame.onRuinTheFun();

// Instant plant growth
Game.Objects['Farm'].minigame.nextStep = 0;

// Free seed planting
Game.Objects['Farm'].minigame.getCost = function() { return 0; };
```

### Grimoire Magic

```javascript
// Refill magic
Game.Objects['Wizard tower'].minigame.magic = Game.Objects['Wizard tower'].minigame.magicM;

// Infinite magic
Game.Objects['Wizard tower'].minigame.magic = Infinity;

// No spell backfire
Game.Objects['Wizard tower'].minigame.getFailChance = function() { return 0; };
```

### Temple Worship

```javascript
// Refill worship swaps
Game.Objects['Temple'].minigame.swaps = 3;

// Infinite swaps
Game.Objects['Temple'].minigame.swaps = Infinity;

// Force diamond slot
Game.Objects['Temple'].minigame.slot[0] = -1;
```

### Stock Market

```javascript
// Change profits
Game.Objects['Bank'].minigame.profit = amount;

// Unlock all stocks
Game.Objects['Bank'].minigame.onRuinTheFun();
```

## 🐉 Dragon Related

```javascript
// Set dragon level
Game.dragonLevel = level;

// Unlock dragon
Game.Upgrades['A crumbly egg'].earn();

// Max out dragon
for(var i = 0; i < Game.dragonLevels.length; i++) {
    Game.dragonLevel = i;
    Game.UpgradeDragon();
}
```

## 🐞 Debug & Special Cheats

### Debug Mode Commands

```javascript
// Enable debug mode
Game.OpenSesame();

// Unlock everything (debug)
Game.RuinTheFun();

// Get all debug upgrades
Game.GetAllDebugs();

// Toggle debug upgrades
Game.DebugUpgradeCpS();
```

### Special Debug Upgrades

```javascript
// Ultrascience (instant research)
Game.Upgrades['Ultrascience'].earn();

// Gold hoard (frequent golden cookies)
Game.Upgrades['Gold hoard'].earn();

// Neuromancy (toggle upgrades)
Game.Upgrades['Neuromancy'].earn();

// Perfect idling (offline production)
Game.Upgrades['Perfect idling'].earn();

// Magic shenanigans (1000x production)
Game.Upgrades['Magic shenanigans'].earn();
```

## 🔄 Save Manipulation

### Export/Import Save

```javascript
// Export save
Game.ExportSave();

// Import save
Game.ImportSave(saveString);

// Load local save
Game.LoadSave(local);

// Get local storage save
Game.localStorageGet(Game.SaveTo);
```

## Auto-Features

### Auto-Click Features

```javascript
// Auto-click big cookie
setInterval(function() {
    Game.ClickCookie();
    Game.lastClick = (new Date().getTime());
}, 1);

// Auto-click during frenzy only
setInterval(function() {
    if (Game.clickFrenzy > 0) {
        Game.ClickCookie();
    }
}, 1);
```

### Auto-Buy Features

```javascript
// Auto-buy buildings
setInterval(function() {
    Game.ObjectsById.forEach(function(building) {
        if (Game.cookies >= building.price) building.buy(1);
    });
}, 1000);

// Auto-buy upgrades
setInterval(function() {
    Game.UpgradesById.forEach(function(upgrade) {
        if (Game.cookies >= upgrade.basePrice && !upgrade.bought) upgrade.buy();
    });
}, 1000);
```

## ⚠️ Important Notes

- Some commands might trigger the "Cheated cookies taste awful" achievement
- Debug mode can be activated by adding 'saysopensesame' to bakery name
- **Back up your save before using cheats**
- Some cheats may prevent achievements from being earned
- Heavenly chip calculations are based on total cookies baked
- Debug upgrades can drastically change gameplay mechanics
- Using multiple cheats simultaneously may cause unexpected results
- Some functions may need to be repeated after saving/loading

## 🌟 Tips for Safe Cheating

1. **Always export your save** before trying new cheats
2. **Test cheats on a separate save file** first
3. **Use smaller values initially** when modifying numbers
4. **Monitor game performance** when using auto-clickers
5. **Be careful with infinity values** as they can break some features
6. **Remember that some changes** only take effect after refreshing
7. **Check achievement status** after using major cheats
8. **Using cheats may permanently affect** your game progress
9. **Some achievements might become locked** after using cheats
10. **Always backup your save file** before using cheats
11. **The "Cheated cookies taste awful" achievement may be triggered**

## 🔗 Useful Links

- [Official Cookie Clicker Game](http://orteil.dashnet.org/cookieclicker/)
- [Cookie Clicker Wiki](https://cookieclicker.fandom.com/)
- [Save File Calculator](https://cookieclicker.fandom.com/wiki/Garden)

## 📜 License

This guide is provided for educational purposes only. Cookie Clicker is owned by Orteil.

---

**Remember: The fun of Cookie Clicker comes from playing the game naturally. Use these cheats responsibly!** 🍪
