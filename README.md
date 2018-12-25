# TMP_Typewriter

Typewriter for TextMesh Pro. TMP_Typewriter prints out characters one by one. ( Required the DOTween. )

[![](https://img.shields.io/github/release/baba-s/TMP_Typewriter.svg?label=latest%20version)](https://github.com/baba-s/TMP_Typewriter/releases)
[![](https://img.shields.io/github/release-date/baba-s/TMP_Typewriter.svg)](https://github.com/baba-s/TMP_Typewriter/releases)
![](https://img.shields.io/badge/Unity-2017.4%2B-red.svg)
[![](https://img.shields.io/github/license/baba-s/TMP_Typewriter.svg)](https://github.com/baba-s/TMP_Typewriter/blob/master/LICENSE)

## Features

- Support for Rich Text
- Skippable
- Can pause and resume
- OnComplete callback
- Compatible with [CharTweener](https://github.com/mdechatech/CharTweener)

## Version

- Unity 2018.3.0f2
- TextMesh Pro 1.3.0
- DOTween 1.2.055

## How To Use

![](https://cdn-ak.f.st-hatena.com/images/fotolife/b/baba_s/20181225/20181225152543.png)

1. Download and import .unitypackage from [Releases](https://github.com/baba-s/TMP_Typewriter/releases).
2. Add a TMP_Typewriter component to the GameObject.
3. Add `using KoganeUnityLib;` and call the `TMP_Typewriter.Play`.

## Example

### Normal

![](https://cdn-ak.f.st-hatena.com/images/fotolife/b/baba_s/20181224/20181224115900.gif)

```cs
m_typewriter.Play
(
    text        : "ABCDEFG HIJKLMN OPQRSTU",
    speed       : m_speed,
    onComplete  : () => Debug.Log( "Complete !" )
);
```

### Rich Text

![](https://cdn-ak.f.st-hatena.com/images/fotolife/b/baba_s/20181224/20181224115909.gif)

```cs
m_typewriter.Play
(
    text        : @"<size=64>ABCDEFG</size> <color=red>HIJKLMN</color> <sprite=0> <link=""https://www.google.co.jp/"">OPQRSTU</link>",
    speed       : m_speed,
    onComplete  : () => Debug.Log( "Complete !" )
);
```

### Sprite

![](https://cdn-ak.f.st-hatena.com/images/fotolife/b/baba_s/20181224/20181224115917.gif)

```cs
m_typewriter.Play
(
    text        : @"<sprite=0><sprite=0><sprite=1><sprite=2><sprite=3><sprite=4><sprite=5><sprite=6><sprite=7><sprite=8><sprite=9><sprite=10>",
    speed       : m_speed,
    onComplete  : () => Debug.Log( "Complete !" )
);
```

### Skip

![](https://cdn-ak.f.st-hatena.com/images/fotolife/b/baba_s/20181224/20181224115929.gif)

```cs
m_typewriter.Skip();        // with onComplete callback
m_typewriter.Skip( false ); // without onComplete callback
```

### Pause & Resume

![](https://cdn-ak.f.st-hatena.com/images/fotolife/b/baba_s/20181225/20181225202540.gif)

```cs
m_typewriter.Pause();
m_typewriter.Resume();
```

### Other

![](https://cdn-ak.f.st-hatena.com/images/fotolife/b/baba_s/20181225/20181225210140.gif)

Compatible with [CharTweener](https://github.com/mdechatech/CharTweener).
