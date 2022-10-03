# MARIO60333's Script Library

**Здесь находятся скрипты эффектов, создание мною и используемые повсеместно при работе с [Storybrew](https://github.com/Damnae/storybrew). Все скрипты вы можете получить [здесь](https://github.com/MARIO60333/mario60333.github.io), а на этой странице вы познакомитесь с их параметрами.**

**По мере у меня свободного времени и желания, данный репозиторий будет пополнятся новыми скриптами. На текущий момент доступно 3 скрипта.**

**Также вы можете ознакомится с гайдом по Storybrew [здесь](/storybrew-guide/)**

## Установка

Установка проста: поместите необходимые скрипты в директорию `Storybrew/scripts`, а ассеты в директорию мапсета `osu!/Songs/<Здесь название директории мапсета>`. Некоторые скрипты не требуют ассетов или вы должны будете сами найти их, которые будут уместны в вашем проекте, в таком случае для этих скриптов не будет ассетов в репозитории. Все!

## Карта [репозитория](https://github.com/MARIO60333/mario60333.github.io)

```
Репозиторий
│   README.md
│   LICENSE
└───imgs
│
└───Scripts (здесь находятся скрипты)
│       <***>
└───Assets (здесь находятся ассеты(спрайты) для мапсета)
    │
    └───<Script 1>
    │       <Здесь все, что помещается в директорию мапсета>
    └───<Script 2>
    │       <***>
    └───<Script 3>
    │       <***>
    └─── ...
    │
    └───<Script N>
            <***>
```

## Скрипты

Теперь давайте познакомимся со скриптами!

### CanvasWasher

Простой скрипт для отчистки холста, на котором находится сториборд. Без него ваш сториборд будет отрисовыватся поверх фона карты, что влияет на `SB Load`. С ним уйдет фон карты => вы обнулите `SB Load` и он останется в меню при выборе карт. Слой с эффектом оставляете в `Background` в самом низу.
При использовании, не забудьте переключить тип эффекта в слоях _"Индивидуально для каждой сложности"_

### Character

Данный эффект добавляет "Персонажа"(спрайт), который движется от старта и до конца эффекта (с возможностью задавать свои значении времении, когда спрайт движется). Есть возможность плавного появления спрайта на холсте и задавать аддитивный режим для него.

Параметры:

> `CharacterPath`**\*** - Путь до спрайта в директории мапсета

> `Origin`

> `Scale`

> `Opacity`

> `OpacityAnim` - Если включено, спрайт появляется плавно до значения `Opacity`. Длительность эффекта задается следующим параметром

> `OpacitySustain` - Длительность появления спрайта (в миллисекундах). Работает при включенном параметре `OpacityAnim`

> `OpacityEasing` - Задает временную функцию для анимации появления спрайта. Работает при включенном параметре `OpacityAnim`

> `Additive`

> `StartTime`**\***

> `EndTime`**\***

> `StartPos`

> `EndPos`

> `CustomAnimTime` - Если включено, вы можете задать свой интервал времени, когда будет анимация в пределах действия эффекта. Время, задаваемое двумя ниже параметрами, относительно начала действия эффекта `StartTime`

> `StartAnim` - Начальное время анимации относительно `StartTime`. Работает при включенном параметре `CustomAnimTime`

> `EndAnim` - Конечное время анимации относительно `StartTime`. Работает при включенном параметре `CustomAnimTime`

> `Easing`

### Flash

Данный эффект создает вспышку на весь экран. Параметры эффекта сделаны по принципу [ASDR-огибающей](https://ru.wikipedia.org/wiki/ADSR-%D0%BE%D0%B3%D0%B8%D0%B1%D0%B0%D1%8E%D1%89%D0%B0%D1%8F). Эффект достигает своего "апогея" на `StartTime`. Параметры `Duration` и `PreAttack` относительны по отношению `StartTime` (значения в миллисекундах).

![ADSR-огибающая эффекта](/imgs/adf.jpg)

Параметры:

> `FlashPath`**\*** - Путь до спрайта вспышки в директории мапсета

> `StartTime`**\***

> `Duration`

> `Easing`

> `PreAttack`

> `PreAttackEasing`

> `Hold` - Сколько будет длится максимум эффекта, на рисунке не показано, но оно находится между `StartTime` и `Duration` (значение в миллисекундах)

Рекомендация: располагайте слой этого эффекта на `Foreground`, сразу за слоем эффекта `Lyrics`(если присутствует), чтобы не перекрыть текст
