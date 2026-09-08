# Cookie Clicker Cheats Guide

**By TurtleHacksz**

A comprehensive guide to Cookie Clicker console cheats - from basic tricks to advanced exploits.

---

## Table of Contents
1. [Basic Cheats](#basic-cheats)
2. [Advanced Cheats](#advanced-cheats)
3. [How to Use](#how-to-use)
4. [Warnings](#warnings)

---

## Basic Cheats

### Add Cookies
```javascript
// Set exact amount
Game.cookies = 1000000;

// Add to current amount
Game.Earn(500000);

// Infinite cookies
Game.cookies = Infinity;
```

### Unlock Upgrades & Achievements
```javascript
// Unlock all upgrades
Game.SetAllUpgrade(1);

// Unlock all achievements
Game.SetAllAchievs(1);

// Unlock specific upgrade
Game.Unlock('Upgrade name');

// Unlock specific achievement
Game.Win('Achievement name');
```

### Golden Cookies
```javascript
// Spawn a golden cookie
new Game.shimmer('golden');

// Auto-click golden cookies
setInterval(function() {
    Game.shimmers.forEach(function(shimmer) {
        if (shimmer.type == "golden") { shimmer.pop() }
    })
}, 500);
```

### Building Cheats
```javascript
// Make all buildings free
Game.ObjectsById.forEach(function(e) {
    e.basePrice = 0;
    e.refresh();
});
Game.storeToRebuild = 1;

// Add 100 of each building
Game.ObjectsById.forEach(obj => obj.amount += 100);
```

### Game Controls
```javascript
// Save game
Game.WriteSave();

// Load save
Game.LoadSave();

// Hard reset
Game.HardReset();

// Ascend (soft reset)
Game.Ascend();
```

### Sugar Lumps
```javascript
// Add sugar lumps
Game.lumps = 100;

// Remove cooldown
Game.canRefillLump = function() { return true; };
```

---

## Advanced Cheats

### Disable "Cheated Cookies Taste Awful" Achievement
```javascript
// 1. Un-earn the achievement
if (Game.Achievements['Cheated cookies taste awful']) {
    Game.Achievements['Cheated cookies taste awful'].won = 0;
}

// 2. Override the check function
Game.Win = (function(originalWin) {
    return function(what) {
        if (what === 'Cheated cookies taste awful') return;
        return originalWin.apply(this, arguments);
    };
})(Game.Win);

// 3. Recalculate and save
Game.recalculateGains = 1;
Game.WriteSave();

// 4. Update display
if (Game.onMenu === 'stats') {
    Game.UpdateMenu();
}
```

### Advanced Production Boost
```javascript
// Multiply production by 1000x
Game.gainMult = 1000;

// Set cookies per second
Game.cookiesPs = 999999999;

// Set mouse CPS
Game.computedMouseCps = 100000;
```

### Heavenly Chips & Prestige
```javascript
// Add heavenly chips
Game.heavenlyChips = 1000000;
Game.CalculatePrestige();

// Get all heavenly upgrades
Game.UpgradesById.forEach(function(upgrade) {
    if(upgrade.pool == 'prestige') upgrade.earn();
});
```

### Wrinklers
```javascript
// Spawn all wrinklers
for (i = 0; i < Game.wrinklers.length; i++) {
    Game.wrinklers[i].phase = 1;
}

// Make all shiny
for (i = 0; i < Game.wrinklers.length; i++) {
    Game.wrinklers[i].type = 1;
}

// Kill all wrinklers
Game.wrinklers.forEach(me => me.hp = 0);
```

### Grandmapocalypse Control
```javascript
// Change Elder status
Game.elderWrath = 0; // 0=Appeased, 1=Awoken, 2=Displeased, 3=Angered

// Auto-buy Elder Pledge
setInterval(function() {
    if (Game.UpgradesInStore.indexOf(Game.Upgrades["Elder Pledge"]) != -1) {
        Game.Upgrades["Elder Pledge"].buy();
    }
}, 500);
```

### Debug Mode (Everything)
```javascript
// Enable debug mode
Game.OpenSesame();

// Unlock everything
Game.RuinTheFun();

// Get debug upgrades
Game.GetAllDebugs();
```

### Seasons
```javascript
// Force Christmas
Game.season = 'christmas';

// Force Halloween
Game.season = 'halloween';

// Force Easter
Game.season = 'easter';

// Force Valentine's Day
Game.season = 'valentines';
```

### Minigames
```javascript
// Unlock all farm seeds
Game.Objects['Farm'].minigame.onRuinTheFun();

// Infinite magic (Grimoire)
Game.Objects['Wizard tower'].minigame.magic = Infinity;

// Infinite temple swaps
Game.Objects['Temple'].minigame.swaps = Infinity;
```

### Auto-Features
```javascript
// Auto-click big cookie
setInterval(function() {
    Game.ClickCookie();
}, 1);

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

### Visual Tweaks
```javascript
// Toggle particles
Game.particles = 0; // Disable

// Party mode
Game.PARTY = true;

// Change FPS
Game.fps = 1000;

// Disable fancy graphics
Game.prefs.fancy = 0;
```

---

## How to Use

### Step 1: Open Console
- **Chrome/Edge**: `Ctrl + Shift + J` (Windows) or `Cmd + Option + J` (Mac)
- **Firefox**: `Ctrl + Shift + K` (Windows) or `Cmd + Option + K` (Mac)
- **Safari**: `Cmd + Option + C`

### Step 2: Copy & Paste
Select a cheat from above and paste it into the console.

### Step 3: Press Enter
Hit Enter and the cheat will execute!

---

## Warnings

⚠️ **Important:**
- **Back up your save** before using cheats
- The **"Cheated cookies taste awful"** achievement will trigger (use the advanced cheat to disable it)
- Some cheats may **prevent future achievements**
- Using `Infinity` can break some game features
- Always **test on a separate save** first
- Multiple cheats at once may cause **unexpected behavior**
- Some changes only take effect after **refresh/reload**

**Remember: The fun comes from playing naturally! Use cheats responsibly!** 🍪

---

**Made by: TurtleHacksz**
