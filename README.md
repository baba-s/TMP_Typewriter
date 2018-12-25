# TMP_Typewriter

Typewriter for TextMesh Pro. TMP_Typewriter prints out characters one by one. ( Required the DOTween. )

## Features

- Support for Rich Text
- Skippable
- OnComplete callback

## Version

- Unity 2018.3.0f2
- TextMesh Pro 1.3.0
- DOTween 1.2.055

## How To Use

1. Add a TMP_Typewriter component to the GameObject.
2. Call the TMP_Typewriter.Play.

## Example

### Normal

<img src="https://cdn-ak.f.st-hatena.com/images/fotolife/b/baba_s/20181224/20181224115900.gif" />

```cs
m_typewriter.Play
(
    text        : "ABCDEFG HIJKLMN OPQRSTU",
    speed       : m_speed,
    onComplete  : () => Debug.Log( "Complete !" )
);
```

### Rich Text

<img src="https://cdn-ak.f.st-hatena.com/images/fotolife/b/baba_s/20181224/20181224115909.gif" />

```cs
m_typewriter.Play
(
    text        : @"<size=64>ABCDEFG</size> <color=red>HIJKLMN</color> <sprite=0> <link=""https://www.google.co.jp/"">OPQRSTU</link>",
    speed       : m_speed,
    onComplete  : () => Debug.Log( "Complete !" )
);
```

### Sprite

<img src="https://cdn-ak.f.st-hatena.com/images/fotolife/b/baba_s/20181224/20181224115917.gif" />

```cs
m_typewriter.Play
(
    text        : @"<sprite=0><sprite=0><sprite=1><sprite=2><sprite=3><sprite=4><sprite=5><sprite=6><sprite=7><sprite=8><sprite=9><sprite=10>",
    speed       : m_speed,
    onComplete  : () => Debug.Log( "Complete !" )
);
```

### Skip

<img src="https://cdn-ak.f.st-hatena.com/images/fotolife/b/baba_s/20181224/20181224115929.gif" />

```cs
m_typewriter.Skip();        // with onComplete callback
m_typewriter.Skip( false ); // without onComplete callback
```