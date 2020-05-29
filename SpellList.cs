namespace dmtool{
    public class SpellList{
        Spell AbiDalximsHorridWilting = new Spell(
            "Abi-Dalzim’s Horrid Wilting",
            8,
            "Necromancy",
            "1 Action",
            "150 ft / 30 ft",
            "V, S, M *",
            "Instantaneous",
            @"You draw the moisture from every creature in a 30-foot cube centered on a point you choose within range. Each creature in that area must make a Constitution saving throw. Constructs and undead aren’t affected, and plants and water elementals make this saving throw with disadvantage. A creature takes 12d8 necrotic damage on a failed save, or half as much damage on a successful one. Nonmagical plants in the area that aren’t creatures, such as trees and shrubs, wither and die instantly.",
            "Necrotic"
        );
        Spell AbsorbElements = new Spell(
            "Absorb Elements",
            1,
            "Abjuration",
            "1 Reaction",
            "Self",
            "S",
            "1 Round",
            @"The spell captures some of the incoming energy, lessening its effect on you and storing it for your next melee attack. You have resistance to the triggering damage type until the start of your next turn. Also, the first time you hit with a melee attack on your next turn, the target takes an extra 1d6 damage of the triggering type, and the spell ends.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the extra damage increases by 1d6 for each slot level above 1st.",
            "Acid"
        );
        Spell AcidArrow = new Spell(
            "Acid Arrow",
            2,
            "Evocation",
            "1 Action",
            "90 ft",
            "V, S, M",
            "Instantaneous",
            @"A shimmering green arrow streaks toward a target within range and bursts in a spray of acid. Make a ranged spell attack against the target. On a hit, the target takes 4d4 acid damage immediately and 2d4 acid damage at the end of its next turn. On a miss, the arrow splashes the target with acid for half as much of the initial damage and no damage at the end of its next turn.

At Higher Levels. When you cast this spell using a spell slot of 3rd level or higher, the damage (both initial and later) increases by 1d4 for each slot level above 2nd.",
            "Acid"
        );
        Spell AcidSplash = new Spell(
            "Acid Splash",
            0,
            "Conjuration",
            "1 action",
            "60 ft",
            "V, S",
            "Instantaneous",
            @"You hurl a bubble of acid. Choose one or two creatures you can see within range. If you choose two, they must be within 5 feet of each other. A target must succeed on a Dexterity saving throw or take 1d6 acid damage.

This spell’s damage increases by 1d6 when you reach 5th level (2d6), 11th level (3d6), and 17th level (4d6).",
            "Acid"
        );
        Spell AcidStream = new Spell(
            "Acid Stream",
            1,
            "Evocation",
            "1 Action",
            "30 ft",
            "V, S, M",
            "1 minute",
            @"A stream of acid emanates from you in a line 30 feet long and 5 feet wide in a direction you choose. Each creature in the line must succeed on a Dexterity saving throw or be covered in acid for the spell’s duration or until a creature uses its action to scrape or wash the acid off itself or another creature. A creature covered in the acid takes 3d4 acid damage at start of each of its turns.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d4 for each slot level above 1st.",
            "Acid"
        );
        Spell AganazzarsScorcher = new Spell(
            "Aganazzar's Scorcher",
            2,
            "Evocation",
            "1 Action",
            "30 ft",
            "V, S, M",
            "Instantaneous",
            @"A line of roaring flame 30 feet long and 5 feet wide emanates from you in a direction you choose. Each creature in the line must make a Dexterity saving throw. A creature takes 3d8 fire damage on a failed save, or half as much damage on a successful one.

At Higher Levels. When you cast this spell using a spell slot of 3rd level or higher, the damage increases by 1d8 for each slot level above 2nd.",
            "Fire"
        );
        Spell Aid = new Spell(
            "Aid",
            2,
            "Abjuration",
            "1 Action",
            "30 ft",
            "V, S, M",
            "8 hours",
            @"Your spell bolsters your allies with toughness and resolve. Choose up to three creatures within range. Each target's hit point maximum and current hit points increase by 5 for the duration.

At Higher Levels. When you cast this spell using a spell slot of 3rd level or higher, a target's hit points increase by an additional 5 for each slot level above 2nd.",
            "Buff"
        );
        Spell Alarm = new Spell(
            "Alarm",
            1,
            "Abjuration",
            "1 Minute",
            "30 ft",
            "V, S, M",
            "8 Hours",
            @"You set an alarm against unwanted intrusion. Choose a door, a window, or an area within range that is no larger than a 20-foot cube. Until the spell ends, an alarm alerts you whenever a Tiny or larger creature touches or enters the warded area. When you cast the spell, you can designate creatures that won't set off the alarm. You also choose whether the alarm is mental or audible.

A mental alarm alerts you with a ping in your mind if you are within 1 mile of the warded area. This ping awakens you if you are sleeping.

An audible alarm produces the sound of a hand bell for 10 seconds within 60 feet.",
            "Detection"
        );
        Spell AlterSelf = new Spell(
            "Alter Self",
            2,
            "Transmutation",
            "1 Action",
            "Self",
            "V, S",
            "1 Hour",
            @"You assume a different form. When you cast the spell, choose one of the following options, the effects of which last for the duration of the spell. While the spell lasts, you can end one option as an action to gain the benefits of a different one.

Aquatic Adaptation. You adapt your body to an aquatic environment, sprouting gills and growing webbing between your fingers. You can breathe underwater and gain a swimming speed equal to your walking speed.

Change Appearance. You transform your appearance. You decide what you look like, including your height, weight, facial features, sound of your voice, hair length, coloration, and distinguishing characteristics, if any. You can make yourself appear as a member of another race, though none of your statistics change. You also can't appear as a creature of a different size than you, and your basic shape stays the same; if you're bipedal, you can't use this spell to become quadrupedal, for instance. At any time for the duration of the spell, you can use your action to change your appearance in this way again.

Natural Weapons. You grow claws, fangs, spines, horns, or a different natural weapon of your choice. Your unarmed strikes deal 1d6 bludgeoning, piercing, or slashing damage, as appropriate to the natural weapon you chose, and you are proficient with your unarmed strikes. Finally, the natural weapon is magic and you have a +1 bonus to the attack and damage rolls you make using it.",
            "Shapechanging"
        );
        Spell AnimalFriendship = new Spell(
            "Animal Friendship",
            1,
            "Enchantment",
            "1 action",
            "30 ft",
            "V, S, M",
            "24 Hours",
            @"This spell lets you convince a beast that you mean it no harm. Choose a beast that you can see within range. It must see and hear you. If the beast's Intelligence is 4 or higher, the spell fails. Otherwise, the beast must succeed on a Wisdom saving throw or be charmed by you for the spell's duration. If you or one of your companions harms the target, the spell ends.

At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, you can affect one additional beast for each slot level above 1st.",
            "Charmed"
        );
        Spell AnimalMessenger = new Spell(
            "Animal Messenger",
            2,
            "Enchantment",
            "1 Action",
            "30 ft",
            "V, S, M",
            "24 Hours",
            @"By means of this spell, you use an animal to deliver a message. Choose a Tiny beast you can see within range, such as a squirrel, a blue jay, or a bat. You specify a location, which you must have visited, and a recipient who matches a general description, such as ""a man or woman dressed in the uniform of the town guard"" or ""a red-haired dwarf wearing a pointed hat."" You also speak a message of up to twenty-five words. The target beast travels for the duration of the spell toward the specified location, covering about 50 miles per 24 hours for a flying messenger, or 25 miles for other animals.

When the messenger arrives, it delivers your message to the creature that you described, replicating the sound of your voice. The messenger speaks only to a creature matching the description you gave. If the messenger doesn't reach its destination before the spell ends, the message is lost, and the beast makes its way back to where you cast this spell.

At Higher Levels. If you cast this spell using a spell slot of 3rd level or higher, the duration of the spell increases by 48 hours for each slot level above 2nd.",
            "Communication"
        );
        Spell AnimalShapes = new Spell(
            "Animal Shapes",
            8,
            "Transmutation",
            "1 Action",
            "30 ft",
            "V, S",
            "24 Hours",
            @"Your magic turns others into beasts. Choose any number of willing creatures that you can see within range. You transform each target into the form of a Large or smaller beast with a challenge rating of 4 or lower. On subsequent turns, you can use your action to transform affected creatures into new forms.

The transformation lasts for the duration for each target, or until the target drops to 0 hit points or dies. You can choose a different form for each target. A target's game statistics are replaced by the statistics of the chosen beast, though the target retains its alignment and Intelligence, Wisdom, and Charisma scores. The target assumes the hit points of its new form, and when it reverts to its normal form, it returns to the number of hit points it had before it transformed. If it reverts as a result of dropping to 0 hit points, any excess damage carries over to its normal form. As long as the excess damage doesn't reduce the creature's normal form to 0 hit points, it isn't knocked unconscious. The creature is limited in the actions it can perform by the nature of its new form, and it can't speak or cast spells.

The target's gear melds into the new form. The target can't activate, wield, or otherwise benefit from any of its equipment.

Spell Tags: SHAPECHANGING",
            "Shapechanging"
        );
        Spell AnimateDead = new Spell(
            "Animal Dead",
            3,
            "Necromancy",
            "1 Minute",
            "10 ft",
            "V, S, M",
            "Instantaneous",
            @"This spell creates an undead servant. Choose a pile of bones or a corpse of a Medium or Small humanoid within range. Your spell imbues the target with a foul mimicry of life, raising it as an undead creature. The target becomes a skeleton if you chose bones or a zombie if you chose a corpse (the GM has the creature's game statistics).

On each of your turns, you can use a bonus action to mentally command any creature you made with this spell if the creature is within 60 feet of you (if you control multiple creatures, you can command any or all of them at the same time, issuing the same command to each one). You decide what action the creature will take and where it will move during its next turn, or you can issue a general command, such as to guard a particular chamber or corridor. If you issue no commands, the creature only defends itself against hostile creatures. Once given an order, the creature continues to follow it until its task is complete.

The creature is under your control for 24 hours, after which it stops obeying any command you've given it. To maintain control of the creature for another 24 hours, you must cast this spell on the creature again before the current 24-hour period ends. This use of the spell reasserts your control over up to four creatures you have animated with this spell, rather than animating a new one.

At Higher Levels. When you cast this spell using a spell slot of 4th level or higher, you animate or reassert control over two additional undead creatures for each slot level above 3rd. Each of the creatures must come from a different corpse or pile of bones.",
            "Creation"
        );
        Spell AntilifeShell = new Spell(
            "Antilife Shell",
            5,
            "Abjuration",
            "1 Action",
            "10 ft",
            "V, S",
            "1 Hour",
            @"A shimmering barrier extends out from you in a 10-foot radius and moves with you, remaining centered on you and hedging out creatures other than undead and constructs. The barrier lasts for the duration.

The barrier prevents an affected creature from passing or reaching through. An affected creature can cast spells or make attacks with ranged or reach weapons through the barrier.

If you move so that an affected creature is forced to pass through the barrier, the spell ends.",
            "Control"
        );
        Spell AntimagicField = new Spell(
            "Antimagic Field",
            8,
            "Abjuration",
            "1 Action",
            "10 ft",
            "V, S, M",
            "1 Hour",
            @"A 10-foot-radius invisible sphere of antimagic surrounds you. This area is divorced from the magical energy that suffuses the multiverse. Within the sphere, spells can't be cast, summoned creatures disappear, and even magic items become mundane. Until the spell ends, the sphere moves with you, centered on you.

Spells and other magical effects, except those created by an artifact or a deity, are suppressed in the sphere and can't protrude into it. A slot expended to cast a suppressed spell is consumed. While an effect is suppressed, it doesn't function, but the time it spends suppressed counts against its duration.

Targeted Effects. Spells and other magical effects, such as magic missile and charm person, that target a creature or an object in the sphere have no effect on that target.

Areas of Magic. The area of another spell or magical effect, such as fireball, can't extend into the sphere. If the sphere overlaps an area of magic, the part of the area that is covered by the sphere is suppressed. For example, the flames created by a wall of fire are suppressed within the sphere, creating a gap in the wall if the overlap is large enough.

Spells. Any active spell or other magical effect on a creature or an object in the sphere is suppressed while the creature or object is in it.

Magic Items. The properties and powers of magic items are suppressed in the sphere. For example, a longsword, +1 in the sphere functions as a nonmagical longsword.

A magic weapon's properties and powers are suppressed if it is used against a target in the sphere or wielded by an attacker in the sphere. If a magic weapon or a piece of magic ammunition fully leaves the sphere (for example, if you fire a magic arrow or throw a magic spear at a target outside the sphere), the magic of the item ceases to be suppressed as soon as it exits.

Magical Travel. Teleportation and planar travel fail to work in the sphere, whether the sphere is the destination or the departure point for such magical travel. A portal to another location, world, or plane of existence, as well as an opening to an extradimensional space such as that created by the rope trick spell, temporarily closes while in the sphere.

Creatures and Objects. A creature or object summoned or created by magic temporarily winks out of existence in the sphere. Such a creature instantly reappears once the space the creature occupied is no longer within the sphere.

Dispel Magic. Spells and magical effects such as dispel magic have no effect on the sphere. Likewise, the spheres created by different antimagic field spells don't nullify each other.",
            "Control"
        );
        Spell AntipathySympathy = new Spell(
            "Antipathy/Sympathy",
            8,
            "Enchantment",
            "1 Hour",
            "60 ft / 200 ft",
            "V, S, M",
            "10 Days",
            @"This spell attracts or repels creatures of your choice. You target something within range, either a Huge or smaller object or creature or an area that is no larger than a 200-foot cube. Then specify a kind of intelligent creature, such as red dragons, goblins, or vampires. You invest the target with an aura that either attracts or repels the specified creatures for the duration. Choose antipathy or sympathy as the aura's effect.

Antipathy. The enchantment causes creatures of the kind you designated to feel an intense urge to leave the area and avoid the target. When such a creature can see the target or comes within 60 feet of it, the creature must succeed on a Wisdom saving throw or become frightened. The creature remains frightened while it can see the target or is within 60 feet of it. While frightened by the target, the creature must use its movement to move to the nearest safe spot from which it can't see the target. If the creature moves more than 60 feet from the target and can't see it, the creature is no longer frightened, but the creature becomes frightened again if it regains sight of the target or moves within 60 feet of it.

Sympathy. The enchantment causes the specified creatures to feel an intense urge to approach the target while within 60 feet of it or able to see it. When such a creature can see the target or comes within 60 feet of it, the creature must succeed on a Wisdom saving throw or use its movement on each of its turns to enter the area or move within reach of the target. When the creature has done so, it can't willingly move away from the target.

If the target damages or otherwise harms an affected creature, the affected creature can make a Wisdom saving throw to end the effect, as described below.

Ending the Effect. If an affected creature ends its turn while not within 60 feet of the target or able to see it, the creature makes a Wisdom saving throw. On a successful save, the creature is no longer affected by the target and recognizes the feeling of repugnance or attraction as magical. In addition, a creature affected by the spell is allowed another Wisdom saving throw every 24 hours while the spell persists.

A creature that successfully saves against this effect is immune to it for 1 minute, after which time it can be affected again.",
            "Frightened"
        );
        Spell ArcaneEye = new Spell(
            "Arcane Eye",
            4,
            "Divination",
            "1 Action",
            "30 ft",
            "V, S, M",
            "1 Hour",
            @"You create an invisible, magical eye within range that hovers in the air for the duration.

You mentally receive visual information from the eye, which has normal vision and darkvision out to 30 feet. The eye can look in every direction.

As an action, you can move the eye up to 30 feet in any direction. There is no limit to how far away from you the eye can move, but it can't enter another plane of existence. A solid barrier blocks the eye's movement, but the eye can pass through an opening as small as 1 inch in diameter.",
            "Detection"
        );
        Spell ArcaneGate = new Spell(
            "Arcane Gate",
            6,
            "Conjuration",
            "1 Action",
            "500 ft",
            "V, S",
            "Concentration, 10 minutes",
            @"You create linked teleportation portals that remain open for the duration.
Choose two points on the ground that you can see, one point within 10 feet of you and one point within 500 feet of you. A circular portal, 10 feet in diameter, opens over each point. If the portal would open in the space occupied by a creature, the spell fails, and the casting is lost.

 The portals are two-dimensional glowing rings filled with mist, hovering inches from the ground and perpendicular to it at the points you choose. A ring is visible only from one side (your choice), which is the side that functions as a portal.
 
Any creature or object entering the portal exits from the other portal as if the two were adjacent to each other; passing through a portal from the nonportal side has no effect. The mist that fills each portal is opaque and blocks vision through it. On your turn, you can rotate the rings as a bonus action so that the active side faces in a different direction.",
            "idk"
        );
        Spell ArcaneLock = new Spell(
            "Arcane Lock",
            2,
            "Abjuration",
            "1 Action",
            "Touch",
            "V, S, M (gold dust worth 25 gp)",
            "Until Dispelled",
            @"You touch a closed door, window, gate, chest, or other entryway, and it becomes locked for the duration.
You and the creatures you designate when you cast this spell can open the object normally. You can also set a password that, when spoken within 5 feet of the object, suppresses this spell for 1 minute. Otherwise, it is impassable until it is broken or the spell is dispelled or suppressed. Casting knock on the object suppresses arcane lock for 10 minutes.

While affected by this spell, the object is more difficult to break or force open; the DC to break it or pick any locks on it increases by 10.",
            "idk"
        );
        Spell ArmorOfAgathys = new Spell(
            "Armor of Agathys",
            1,
            "Abjuration",
            "1 Action",
            "Self",
            "V, S, M (a cup of water)",
            "1 Hour",
            @"A protective magical force surrounds you, manifesting as a spectral frost that covers you and your gear.
You gain 5 temporary hit points for the duration. If a creature hits you with a melee attack while you have these hit points, the creature takes 5 cold damage. 
At higher level: When you cast this spell using a spell slot of 2nd level or higher, both the temporary hit points and the cold damage increase by 5 for each slot",
            "idk"
        );
        Spell ArmsOfHadar = new Spell(
            "Arms of Hadar",
            1,
            "Conjuration",
            "1 Action",
            "Self / 10 ft radius",
            "V, S",
            "Instantaneous",
            @"You invoke the power of Hadar, the Dark Hunger.
Tendrils of dark energy erupt from you and batter all creatures within 10 feet of you. Each creature in that area must make a Strength saving throw. On a failed save, a target takes 2d6 necrotic damage and can’t take reactions until its next turn. On a successful save, the creature takes half damage, but suffers no other effect. 
At higher level: When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d6 for each slot level above 1st.",
            "Necrotic"
        );
        Spell AstralProjection = new Spell(
            "Astral Projection",
            9,
            "Necromancy",
            "1 Hour",
            "10 ft",
            "V, S, M (for each creature you affect with this spell, you must provide one jacinth worth at least 1,000 gp and one ornately carved bar of silver worth at least 100 gp, all of which the spell consumes)",
            "Special",
            @"You and up to eight willing creatures within range project your astral bodies into the Astral Plane (the spell fails and the casting is wasted if you are already on that plane).
The material body you leave behind is unconscious and in a state of suspended animation; it doesn’t need food or air and doesn’t age. 

Your astral body resembles your mortal form in almost every way, replicating your game statistics and possessions. The principal difference is the addition of a silvery cord that extends from between your shoulder blades and trails behind you, fading to invisibility after 1 foot. This cord is your tether to your material body. As long as the tether remains intact, you can find your way home. If the cord is cut something that can happen only when an effect specifically states that it does your soul and body are separated, killing you instantly. 

Your astral form can freely travel through the Astral Plane and can pass through portals there leading to any other plane. If you enter a new plane or return to the plane you were on when casting this spell, your body and possessions are transported along the silver cord, allowing you to re-enter your body as you enter the new plane. Your astral form is a separate incarnation. Any damage or other effects that apply to it have no effect on your physical body, nor do they persist when you return to it. The spell ends for you and your companions when you use your action to dismiss it. When the spell ends, the affected creature returns to its physical body, and it awakens. 

The spell might also end early for you or one of your companions. A successful dispel magic spell used against an astral or physical body ends the spell for that creature. If a creature’s original body or its astral form drops to 0 hit points, the spell ends for that creature. If the spell ends and the silver cord is intact, the cord pulls the creature’s astral form back to its body, ending its state of suspended animation. If you are returned to your body prematurely, your companions remain in their astral forms and must find their own way back to their bodies, usually by dropping to 0 hit points.",
            "idk"
        );
        Spell Augury = new Spell(
            "Augury",
            2,
            "Divination",
            "1 Minute",
            "Self",
            "V, S, M (specially marked sticks, bones, or similar tokens worth at least 25 gp)",
            "Instantaneous",
            @"By casting gem-inlaid sticks, rolling dragon bones, laying out ornate cards, or employing some other divining tool, you receive an omen from an otherworldly entity about the results of a specific course of action that you plan to take within the next 30 minutes. The DM chooses from the following possible omens:

• Weal, for good results
• Woe, for bad results
• Weal and woe, for both good and bad results
• Nothing, for results that aren’t especially good or bad

The spell doesn’t take into account any possible circumstances that might change the outcome, such as the casting of additional spells or the loss or gain of a companion. If you cast the spell two or more times before completing your next long rest, there is a cumulative 25 percent chance for each casting after the first that you get a random reading. The DM makes this roll in secret.",
            "idk"
        );
        Spell AuraOfLife = new Spell(
            "Aura of Life",
            4,
            "Abjuration",
            "1 Action",
            "Self / 30 ft radius",
            "V",
            "Concentration, 10 minutes",
            @"Life-preserving energy radiates from you in an aura with a 30-foot radius.
Until the spll ends, the aura moves with you, centered on you. Each nonhostile creature in the aura (including you) has resistance to necrotic damage, and its hit point maximum can’t be reduced. In addition, a nonhostile, living creature regains 1 hit point when it starts its turn in the arua with 0 hit points.

",
            "idk"
        );
        Spell AuraOfPurity = new Spell(
            "Aura of Purity",
            4,
            "Abjuration",
            "1 Action",
            "Self / 30 ft radius",
            "V",
            "Concentration, 10 minutes",
            @"Purifying energy radiates from you in an aura with a 30-foot radius.
Until the spell ends, the aura moves with you, centered on you. Each nonhostile creature in the aura (including you) can’t become diseased, has resistance to poison damage, and has advantage on saving throws against effects that cause any of the following conditions: blnded, charmed, deafended, frightened, paralyzed, poisoned, and stunned.

",
            "idk"
        );
        Spell AuraOfVitality = new Spell(
            "Aura of Vitality",
            3,
            "Evocation",
            "1 Action",
            "30 ft radius",
            "V",
            "Concentration, 1 minute",
            @"Healing energy radiates from you in an aura with a 30-foot radius.
Until the spell ends, the aura moves with you, centered on you. You can use a bonus action to cause one creature in the aura (including you) to regain 2d6 hit points.",
            "Healing"
        );
        Spell Awaken = new Spell(
            "Awaken",
            5,
            "Transmutaion",
            "8 Hours",
            "Touch",
            "V, S, M (an agate worth at least 1,000 gp, which the spell consumes)",
            "Instantaneous",
            @"After spending the casting time tracing magical pathways within a precious gemstone, you touch a huge or smaller beast or plant.
The target must have either no Intelligence score or an Intelligence of 3 or less. The target gains an Intelligence of 10. The target also gains the ability to speak one language you know. If the target is a plant, it gains the ability to move its limbs, roots, vinces, creepers, and so forth, and it gains senses similar to a huamn’s. Your DM chooses statistics appropriate for the awakened plant, such as the statistics for the awakened shrub or the awakened tree.

The awakened beast or plant is charmed by you for 30 days or until you and your companions do anything harmful to it. When the charmed condition ends, the awakened creature chooses whether to remain friendly to you, based on how you treated it while it was charmed.

",
            "idk"
        );
        Spell Bane = new Spell(
            "Bane",
            1,
            "Enchantment",
            "1 Action",
            "30 ft",
            "V, S, M (a drop of blood)",
            "Concentration, 1 minute",
            @"Up to three creatures of your choice that you can see within range must make Charisma saving throws. Whenever a target that fails this saving throw makes an attack roll or a saving throw before the spell ends, the target must roll a d4 and subtract the number rolled from the attack roll or saving throw.

At higher level
When you cast this spell using a spelslot of 2nd level or higher, you can target one aditional creature for each slot level above 1st.",
            "idk"
        );
        Spell BanishingSmite = new Spell(
            "Banishing Smite",
            5,
            "Abjuration",
            "1 Bonus Action",
            "Self",
            "V",
            "Concentration, 1 minute",
            @"The next time you hit a creature with a weapon attack before this spell ends, your weapon crackles with force, and the attack deals an extra 5d10 force damage to the target. Additionally, if this attack reduces the target to 50 hit points of fewer, you banish it. If the target is native to a different plane of existence than the on you’re on, the target disappears, returning to its home plane. If the target is native to the plane you’re on, the creature vanishes into a harmless demiplane. While there, the target is incapacitated. It remains there until the spell ends, at which point the target reappears in the space it left or in the nearest unoccupied space if that space is occupied.",
            "Force"
        );
        Spell Banishment = new Spell(
            "Banishment",
            4,
            "Abjuration",
            "1 Action",
            "60 ft",
            "V, S, M (an item distasteful to the target)",
            "Concentration, 1 minute",
            @"You attempt to send one creature that you can see within range to another place of existence. The target must succeed on a Charisma saving throw or be banished.

If the target is native to the plane of existence you’re on, you banish the target to a harmless demiplane. While there, the target is incapacitated. The target remains there until the spell ends, at which point the target reappears in the space it left or in the nearest unoccupied space if that space is occupied.

If the target is native to a different plane of existence that the one you’re on, the target is banished with a faint popping noise, returning to its home plane.
If the spell ends before 1 minute has passed, the target reappears in the space it left or in the nearest unoccupied space if that space is occupied. Otherwise, the target doesn’t return.

At higher level
When you cast this spell using a spell slot of 5th level or higher, you can target one additional creature for each slot level above 4th.",
            "idk"
        );
        Spell Barkskin = new Spell(
            "Barkskin",
            2,
            "Transmutation",
            "1 Action",
            "Touch",
            "V, S, M (A handful of oak bark)",
            "Concentration, 1 hour",
            @"You touch a willing creature. Until the spellends, the target’s skin has a rough, bark-like appearance, and the target’s AC can’t be less than 16, regardless of what kind of armor it is wearing.",
            "idk"
        );
        Spell BeaconOfHope = new Spell(
            "Beacon of Hope",
            3,
            "Abjuration",
            "1 Action",
            "30 ft",
            "V, S",
            "Concentration, 1 minute",
            "This spell bestows hope and vitality. Choose any number of creatures within range. For the duration, each target has advantage on Wisdom saving throws and death saving throws, and regains the maximum number of hit points possible from any healing.",
            "idk"
        );
        Spell BeastBond = new Spell(
            "Beast Bond",
            1,
            "Divination",
            "1 Action",
            "Touch",
            "V, S, M (a bit of fur wrapped in a cloth)",
            "Concentration, 10 minutes",
            @"You establish a telepathic link with one beast you touch that is friendly to you or charmed by you. The spell fails if the beast’s Intelligence is 4 or higher. Until the spell ends, the link is active while you and the beast are within line of sight of each other. Through the link, the beast can understand your telepathic messages to it, and it can telepathically communicate simple emotions and concepts back to you. While the link is active, the beast gains advantage on attack rolls against any creature within 5 feet of you that you can see.

",
            "idk"
        );
        Spell BeastSense = new Spell(
            "Beast Sense",
            2,
            "Divination",
            "1 Action",
            "Touch",
            "S",
            "Concentration, 1 hour",
            @"You touch a willing beast. For the duration of the spell, you can use your action to see through the beast’s eyes and hear what it hears, and continue to do so until you use your action to return to your normal senses.",
            "idk"
        );
        Spell BestowCurse = new Spell(
            "Bestow Curse",
            3,
            "Necromancy",
            "1 Action",
            "Touch",
            "V, S",
            "Concentration, 1 minute",
            @"You touch a creature, and that creature must succeed on a Wisdom saving throw or become cursed for the duration of the spell. When you cast this spell, choose the nature of the curse from the following options:

* Choose one ability score. While cursed, the target has disadvantage on ability checks and saving throws made with that ability score.
* While cursed, the target has disadvantage on attack rolls against you.
* While cursed, the target must make a Wisdom saving throw at the start of each of its turns. If it fails, it wastes its action that turn doing nothing.
* While the target is cursed, your attacks and spells deal an extra 1d8 necrotic damage to the target.

A remove curse spell ends this effect. At the DM’s option, you may choose an alternative curse effect, but it should be no more powerful than those described above.
The DM has final say on such a curse’s effect.
At higher level
If you cast this spell using a spell slot of 4th level or higher, the duration is concentration, up to 10 minutes.
If you use a spell slot of 5th level or higher, the duration is 8 hours.
If you use a spell slot of 7th level or higher, the duration is 24 hours.
If you use a 9th level spell slot, the spell lasts until it is dispelled.
Using a spell slot of 5th level or higher grants a duration that doesn’t require concentration.",
            "Necrotic"
        );
        Spell BigbysHand = new Spell(
            "Bigby's Hand",
            5,
            "Evocation",
            "1 Action",
            "120 ft",
            "V, S, M (An eggshell and a snakeskin glove)",
            "Concentration, 1 minute",
            @"You create a Large hand of shimmering, translucent force in an unoccupied space that you can see within range. The hand lasts for the spell’s duration, and it moves at your command, mimicking the movements of your own hand.

The hand is an object that has AC 20 and hit points equal to your hit point maximum. If it drops to 0 hit points, the spell ends. It has a Strength of 26 (+8) and a Dexterity of 10 (+0). The hand doesn’t fill its space.

When you cast the spell and as a bonus action on your subsequent turns, you can move the hand up to 60 feet and then cause one of the following effects with it.

Clenched Fist 
The hand strikes one creature or object within 5 feet of it. Make a melee spell attack for the hand using your game statistics. On a hit, the target takes 4d8 force damage.

Forceful Hand
The hand attempts to push a creature within 5 feet of it in a direction you choose. Make a check with the hand’s Strength contested by the Strength (Athletics) check of the target. If the target is Medium or smaller, you have advantage on the check. If you succeed, the hand pushes the target up to 5 feet plus a number of feet equal to five times your spellcasting ability modifier. The hand moves with the target to remain within 5 feet of it.

Grasping Hand
The hand attempts to grapple a Huge or smaller creature within 5 feet of it. You use the hand’s Strength score to resolve the grapple. If the target is Medium or smaller, you have advantage on the check. While the hand is grappling the target, you can use a bonus action to have the hand crush it. When you do so, the target takes bludgeoning damage equal to 2d6 + your spellcasting ability modifier.

Interposing Hand
The hand interposes itself between you and a creature you choose until you give the hand a different command. The hand moves to stay between you and the target, providing you with half cover against the target. The target can’t move through the hand’s space if its Strength score is less than or equal to the hand’s Strength score. If its Strength score is higher than the hand’s Strength score, the target can move toward you through the hand’s space, but that space is difficult terrain for the target.

At higher level
When you cast this spell using a spell slot of 6th level or higher, the damage from the clenched fist option increases by 2d8 and the damage from the grasping hand increases by 2d6 for each slot level above 5th.",
            "idk"
        );
        Spell BladeBarrier = new Spell(
            "Blade Barrier",
            6,
            "Evocation",
            "1 Action",
            "90 ft",
            "V, S",
            "Concentration, 10 minutes",
            @"You create a vertical wall of whirling, razor-sharp blades made of magical energy. The wall appears within range and lasts for the duration. You can make a straight wall up to 100 feet long, 20 feet high, and 5 feet thick, or a ringed wall up to 60 feet in diameter, 20 feet high, and 5 feet thick. The wall provides three-quarters cover to creatures behind it, and its space is difficult terrain.

 When a creature enters the wall’s area for the first time on a turn or starts its turn there, the creature must make a Dexterity saving throw. On a failed save, the creature takes 6 d10 slashing damage. On a successful save, the creature takes half as much damage.",
            "idk"
        );
        Spell BladeWard = new Spell(
            "Blade Ward",
            0,
            "Abjuration",
            "1 Action",
            "Self",
            "V, S",
            "1 round",
            @"You extend your hand and trace a sigil of warding in the air. Until the end of your next turn, you have resistance against bludgeoning, piercing, and slashing damage dealt by weapon attacks.",
            "idk"
        );
        Spell Bless = new Spell(
            "Bless",
            1,
            "Enchantment",
            "1 Action",
            "30 ft",
            "V, S, M (a sprinkling of holy water)",
            "Concentration, 1 minute",
            @"You bless up to three creatures of your choice within range. Whenever a target makes an attack roll or a saving throw before the spell ends, the target can roll a d4 and add the number rolled to the attack roll or saving throw. 

At higher level
When you cast this spell using a spell slot of 2nd level or higher, you can target one additional creature for each slot level above 1st.",
            "idk"
        );
        Spell Blight = new Spell(
            "Blight",
            4,
            "Necromancy",
            "1 Action",
            "30 ft",
            "V, S",
            "Instantaneous",
            @"Necromantic energy washes over a creature of your choice that you can see within range, draining moisture and vitality from it. The target must make a Constitution saving throw. The target takes 8d8 necrotic damage on a failed save, or half as much damage on a successful one. This spell has no effect on undead or constructs.

If you target a plant creature or a magical plant, it makes the saving throw with disadvantage, and the spell deals maximum damage to it.

If you target a nonmagical plant that isn’t a creature, such as a tree or shrub, it doesn’t make a saving throw; it simply withers and dies.

At higher level
When you cast this spell using a spell slot of 5th level or higher, the damage increases by 1d8 for each slot level above 4th.",
            "Necrotic"
        );
        Spell BlindingSmite = new Spell(
            "Blinding Smite",
            3,
            "Evocation",
            "1 Bonus Action",
            "Self",
            "V",
            "Concentration, 1 minute",
            @"The next time you hit a creature with a melee weapon attack during this spell’s duration, you weapon flares with a bright light, and the attack deals an extra 3d8 radiant damage to the target. Additionally, the target must succeed on a Constitution saving throw or be blinded until the spell ends.

A creature blinded by this spell makes another Constitution saving throw at the end of each of its turns. On a successful save, it is no longer blinded.",
            "Radiant"
        );
        Spell BlindnessDeafness = new Spell(
            "Blindness/Deafness",
            2,
            "Necromancy",
            "1 Action",
            "30 ft",
            "V",
            "1 minute",
            @"You can blind or deafen a foe. Choose one creature that you can see within range to make a Constitution saving throw. If it fails, the target is either blinded or deafened (your choice) for the duration. At the end of each of its turns, the target can make a Constitution saving throw. On a success, the spell ends. 

At higher level
When you cast this spell using a spell slot of 3rd level or higher, you can target one additional creature for each slot level above 2nd.",
            "idk"
        );
        Spell Blink = new Spell(
            "Blink",
            3,
            "Transmutation",
            "1 action",
            "Self",
            "V, S",
            "1 minute",
            @"Roll a d20 at the end of each of your turns for the duration of the spell. On a roll of 11 or higher, you vanish from your current plane of existence and appear in the Etheral Plane (the spell fails and the casting is wasted if you were already on that plane).

At the start of you next turn, and when the spell ends if you are on the Etheral Plane, you return to an unoccupied space of your choice that you can see within 10 feet of the space you vanished from. If no unoccupied space is available within that range, you appear in the nearest unoccupied space (chosen at random if more that one space is equally near). You can dismiss this spell as an action.

While on the Ethereal Plane, you can see and hear the plane you originated from, which is cast in shades of gray, and you can’t see anything more than 60 feet away.You can only affect and be affected by other reatures on the Ethereal Plane. Creature that aren’t there can’t perceive you or interact with you, unless they have the ability to do so.",
            "idk"
        );
        Spell Blur = new Spell(
            "Blur",
            2,
            "Illusion",
            "1 Action",
            "Self",
            "V",
            "Concentration, 1 minute",
            @"Your body becomes blurred, shifting and wavering to all who can see you. For the duration, any creature has disadvantage on attack rolls against you. An attacker is immune to this effect if it doesnt rely on sight, as with blindsight, or can see through illusions, as with truesight.",
            "idk"
        );
        Spell BonesOfTheEarth = new Spell(
            "Bones of the Earth",
            6,
            "Transmutation",
            "1 Action",
            "120 ft",
            "V, S",
            "Instantaneous",
            @"You cause up to six pillars of stone to burst from places on the ground that you can see within range. Each pillar is a cylinder that has a diameter of 5 feet and a height of up to 30 feet. The ground where a pillar appears must be wide enough for its diameter, and you can target ground under a creature if that creature is Medium or smaller. Each pillar has AC 5 and 30 hit points. When reduced to 0 hit points, a pillar crumbles into rubble, which creates an area of difficult terrain with a 10-foot radius. The rubble lasts until cleared.
If a pillar is created under a creature, that creature must succeed on a Dexterity saving throw or be lifted by the pillar. A creature can choose to fail the save.
If a pillar is prevented from reaching its full height because of a ceiling or other obstacle, a creature on the pillar takes 6d6 bludgeoning damage and is restrained, pinched between the pillar and the obstacle. The restrained creature can use an action to make a Strength or Dexterity check (the creature’s choice) against the spell’s saving throw DC. On a success, the creature is no longer restrained and must either move off the pillar or fall off it.
At Higher Levels. When you cast this spell using a spell slot of 7th level or higher, you can create two additional pillars for each slot level above 6th.",
            "idk"
        );
        Spell BoomingBlade = new Spell(
            "Booming Blade",
            0,
            "Evocation",
            "1 Action",
            "5 ft",
            "V, M(a weapon)",
            "1 Round",
            @"As part of the action used to cast this spell, you must make a melee attack with a weapon against one creature within the spell's range, otherwise the spell fails.
On a hit, the target suffers the attack's normal effects, and it becomes sheathed in booming energy until the start of your next turn. If the target willingly moves be- fore then, it immediately takes 1d8 thunder damage, and the spell ends.
This spell's damage increases when you reach higher levels. 

At higher level
At 5th level, the melee attack deals an extra 1d8 thunder damage to the target, and the damage the target takes for moving increases to 2d8. Both damage rolls increase by 1d8 at 11th level and 17th level.",
            "Thunder"
        );
        Spell BrandingSmite = new Spell(
            "Branding Smite",
            2,
            "Evocation",
            "1 Bonus Action",
            "Self",
            "V",
            "Concentration, 1 minute",
            @"The next time you hit a creature with a weapon attack before this spell ends, the weapon glemas with astral radiance as you strike. The attack deals an extra 2d6 radiant damage to the target, which becomes visible if it is invisible, and the target sheds dim light in a 5-foot radius and can’t become invisible until the spell ends. 

At higher level
When you cast this spell using a spell slot of 3rd level or higher, the extra damage increases by 1d6 for each slot level above 2nd.",
            "Radiant"
        );
        Spell BurningHands = new Spell(
            "Burning Hands",
            1,
            "Evocation",
            "1 Action",
            "Self (15-foot-cone)",
            "V, S",
            "Instantaneous",
            @"As you hold your hands with thumbs touching and fingers spread, a thin sheet of flames shoots forth from your outstretched fingertips. Each creature in a 15-foot cone must make a Dexterity saving throw. A creature takes 3d6 fire damage on a failed save, or half as much damage on a successful one.

The fire ignites any flammable objects in the area that aren’t being worn or carried. 

At higher level
When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d6 for each slot level above 1st.",
            "Fire"
        );
        Spell CallLightning = new Spell(
            "Call Lightning",
            3,
            "Conjuration",
            "1 Action",
            "120 ft",
            "V, S",
            "Concentration, 10 minutes",
            @"A storm cloud appears in the shape of a cylinder that is 10 feet tall with a 60-foot radius, centered on a point you can see 100 feet directly above you. The spell fails if you can’t see a point in the air where the storm cloud could appear (for example, if you are in a room that can’t accommodate the cloud).

When you cast the spell, choose a point you can see within range. A bolt of lightning flashes down from the cloud to that point. Each creature within 5 feet of that point must make a Dexterity saving throw. A creature takes 3d10 lightning damage on a failed save, or half as much damage on a successful one. On each of your turns until the spell ends, you can use your action to call down lightning in this way again, targeting the same point or a different one.

If you are outdoors in stormy conditions when you cast this spell, the spell gives you control over the existing storm instead of creating a new one. Under such conditions, the spell’s damage increases by 1d10. 

At higher level
When you cast this spell using a spell slot of 4th or higher level, the damage increases by 1d10 for each slot level above 3rd.",
            "Lightning"
        );
        Spell CalmEmotions = new Spell(
            "Calm Emotions",
            2,
            "Enchantment",
            "1 Action",
            "60 ft",
            "V, S",
            "Concentration, 1 minute",
            @"You attempt to suppress strong emotions in a group of people.
Each humanoid in a 20-foot-radius sphere centered on a point you choose within range must make a Charisma saving throw; a creature can choose to fail this saving throw if it wishes. If a creature fails its saving throw, choose one of the following two effects. You can suppress any effect causing a target to be charmed or frightened. When this spell ends, any suppressed effect resumes, provided that its duration has not expired in the meantime.

Alternatively, you can make a target indifferent about creatures of your choice that it is hostile toward. This indifference ends if the target is attacked or harmed by a spell or if it witnesses any of its friends being harmed. When the spell ends, the creature becomes hostile again, unless the DM rules otherwise.",
            "idk"
        );
        Spell Catapult = new Spell(
            "Catapult",
            1,
            "Transmutation",
            "1 Action",
            "150 ft",
            "S",
            "Instantaneous",
            @"Choose one object weighing 1 to 5 pounds within range that isn’t being worn or carried. The object flies in a straight line up to 90 feet in a direction you choose before falling to the ground, stopping early if it impacts against a solid surface. If the object would strike a creature, that creature must make a Dexterity saving throw. On a failed save, the object strikes the target and stops moving. In either case, both the object and the creature or solid surface take 3d8 bludgeoning damage.
At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the maximum weight of objects that you can target with this spell increases by 5 pounds, and the damage increases by 1d8, for each slot level above 1st.",
            "idk"
        );
        Spell Catnap = new Spell(
            "Catnap",
            3,
            "Enchantment",
            "1 Action",
            "30 ft",
            "S, M(a pinch of sand)",
            "10 minutes",
            @"You make a calming gesture, and up to three willing creatures of your choice that you can see within range fall unconscious for the spell’s duration. The spell ends on a target early if it takes damage or someone uses an action to shake or slap it awake. If a target remains unconscious for the full duration, that target gains the benefit of a short rest, and it can’t be affected by this spell again until it finishes a long rest.

At higher level
When you cast this spell using a spell slot of 4th level or higher, you can target one additional willing creature for each slot level above 3rd.",
            "idk"
        );
        Spell CauseFear = new Spell(
            "Cause Fear",
            1,
            "Necromancy",
            "1 Action",
            "60 ft",
            "V",
            "Concentration, 1 minute",
            @"You awaken the sense of mortality in one creature you can see within range. A construct or an undead is immune to this effect. The target must succeed on a Wisdom saving throw or become frightened of you until the spell ends. The frightened target can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success.

At higher level
When you cast this spell using a spell slot of 2nd level or higher, you can target one additional creature for each slot level above lst. The creatures must be within 30 feet of each other when you target them.",
            "idk"
        );
        Spell Ceremony = new Spell(
            "Ceremony",
            1,
            "Abjuration",
            "1 Hour",
            "Touch",
            "V, S, M (25 gp worth of powdered silver,which the spell consumes)",
            "Instantaneous",
            @"You perform a special religious ceremony that is infused with magic. When you cast the spell, choose one of the following rites, the target of which must be within 10 feet of you throughout the casting.
Atonement. You touch one willing creature whose alignment has changed, and you make a DC 20 Wisdom (Insight) check. On a successful check, you restore the target to its original alignment.
Bless Water. You touch one vial of water and cause it to become holy water.
Coming of Age. You touch one humanoid who is a young adult. For the next 24 hours, whenever the target makes an ability check, it can roll a d4 and add the number rolled to the ability check. A creature can benefit from this rite only once.
Dedication. You touch one humanoid who wishes to be dedicated to your god’s service. For the next 24 hours, whenever the target makes a saving throw, it can roll a d4 and add the number rolled to the save. A creature can benefit from this rite only once.
Funeral Rite. You touch one corpse, and for the next 7 days, the target can’t become undead by any means short of a wish spell.
Wedding. You touch adult humanoids willing to be bonded together in marriage. For the next 7 days, each target gains a +2 bonus to AC while they are within 30 feet of each other. A creature can benefit from this rite again only if widowed.",
            "idk"
        );
        Spell ChainLightning = new Spell(
            "Chain Lightning",
            6,
            "Evocation",
            "1 Action",
            "150 ft",
            "V, S, M (a bit of fur; a piece of amber, glass, or a crystal rod; and three silver pins)",
            "Instantaneous",
            @"You create a bolt of lightning that arcs toward a target of your choice that you can see within range. Three bolts then leap from that target to as many as three other targets, each of which must be within 30 feet of the first target. A target can be a creature or an object and can be targeted by only one of the bolts.

A target must make a Dexterity saving throw. The target takes 10d8 lightning damage on a failed save, or half as much on a successful one. 

At higher level
When you cast this spell using a spell slot of 7th level or higher, one additional bolt leaps from the first target to another target for each slot level above 6th.",
            "Lightning"
        );
        Spell ChaosBolt = new Spell(
            "Chaos Bolt",
            1,
            "Evocation",
            "1 Action",
            "120 ft",
            "V, S",
            "Instantaneous",
            @"You hurl an undulating, warbling mass of chaotic energy at one creature in range. Make a ranged spell attack against the target. On a hit, the target takes 2d8 + 1d6 damage. Choose one of the d8s. The number rolled on that die determines the attacks damage type, as shown below.
d8 / Damage Type
1 / Acid
2 / Cold
3 / Fire
4 / Force
5 / Lightning
6 / Poison
7 / Psychic
8 / Thunder
If you roll the same number on both d8s, the chaotic energy leaps from the target to a different creature of your choice within 30 feet of it. Make a new attack roll against the new target, and make a new damage roll, which could cause the chaotic energy to leap again. A creature can be targeted only once by each casting of this spell.

At higher level
When you cast this spell using a spell slot of 2nd level or higher, each target takes 1d6 extra damage of the type rolled for each slot level above 1st.",
            "idk"
        );
        Spell CharmMonster = new Spell(
            "Charm Monster",
            4,
            "Enchantment",
            "1 Action",
            "30 ft",
            "V, S",
            "1 Hour",
            @"You attempt to charm a creature you can see within range. It must make a Wisdom saving throw, and it does so with advantage if you or your companions are fighting it. If it fails the saving throw, it is charmed by you until the spell ends or until you or your companions do anything harmful to it. The charmed creature is friendly to you. When the spell ends, the creature knows it was charmed by you.

At higher level
When you cast this spell using a spell slot of 5th level or higher, you can target one additional creature for each slot level above 4th. The creatures must be within 30 feet of each other when you target them.",
            "idk"
        );
        Spell CharmPerson = new Spell(
            "Charm Person",
            1,
            "Enchantment",
            "1 Action",
            "30 ft",
            "V, S",
            "1 hour",
            @"You attempt to charm a humanoid you can see within range.
It must make a Wisdom saving throw, and does so with advantage if you or your companions are fighting it. If it fails the saving throw, it is charmed by you until the spell ends or until you or your companions do anything harmful to it.The charmed creature regards you as a friendly acquaintance. When the spell ends, the creature knows it was charmed by you.

At higher level
When you cast this spell using a spell slot of 2nd level or higher, you can target one additional creature for each slot level above 1st. The creatures must be within 30 feet of each other when you target them.",
            "idk"
        );
        Spell ChillTouch = new Spell(
            "Chill Touch",
            0,
            "Necromancy",
            "1 Action",
            "120 ft",
            "V, S",
            "1 Round",
            @"You create a ghostly, skeletal hand in the space of a creature within range.
Make a ranged spell attack against the creature to assail it with the chill of the grave. On a hit, the target takes 1d8 necrotic damage, and it can’t regain hit points until the start of your next turn. Until then, the hand clings to the target. If you hit an undead target, it also has disadvantage on attack rolls against you until the end of your next turn. 

At higher level
This spell’s damage increases by 1d8 when you reach 5th level (2d8), 11th level (3d8), and 17th level (4d8).",
            "Necrotic"
        );
        Spell ChromaticOrb = new Spell(
            "Chromatic Orb",
            1,
            "Evocation",
            "1 Action",
            "90 ft",
            "V, S, M (a diamond worth at least 50 gp)",
            "Instantaneous",
            @"You hurl a 4-inch-diameter sphere of energy at a creature that you can see within range. You choose acid, cold, fire, lightning, poison, or thunder for the type of orb you create, and then make a ranged spell attack against the target. If the attack hits, the creature takes 3d8 damage of the type you chose. 

At higher level
When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d8 for each slot level above 1st.",
            "idk"
        ); 
   }
}