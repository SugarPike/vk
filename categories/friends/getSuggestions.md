---
layout: default
title: Метод Friends.GetSuggestions
permalink: friends/getSuggestions/
comments: true
---
# Метод Friends.GetSuggestions
Возвращает список профилей пользователей, которые могут быть друзьями текущего пользователя.

Этот метод можно вызвать с [ключом доступа пользователя](https://vk.com/dev/access_token). Требуются [права доступа](https://vk.com/dev/permissions): **friends**.

Страница документации ВКонтакте [friends.getSuggestions](https://vk.com/dev/friends.getSuggestions).

## Синтаксис
``` csharp
public ReadOnlyCollection<User> GetSuggestions(FriendsFilter filter = null, long? count = null, long? offset = null, UsersFields fields = null, NameCase nameCase = null)
```

## Параметры
+ **filter** — типы предлагаемых друзей, которые нужно вернуть, перечисленные через запятую. 
Может принимать следующие значения: *mutual* — пользователи, с которыми много общих друзей; По умолчанию будут возвращены все возможные друзья.
+ **count** — количество рекомендаций, которое необходимо вернуть. Положительное число, максимальное значение *500*, по умолчанию *500*.
+ **offset** — смещение, необходимое для выбора определённого подмножества списка.
+ **fields** — список дополнительных полей, которые необходимо вернуть. Доступные значения: *nickname*, *screen_name*, *sex*, *bdate*, *city*, *country*, *timezone*, *photo_50*, *photo_100*, *photo_200_orig*, *has_mobile*, *contacts*, *education*, *online*, *counters*, *relation*, *last_seen*, *status*, *can_write_private_message*, can_see_all_posts, *can_post*, *universities*.
+ **name_case** — падеж для склонения имени и фамилии пользователя. Возможные значения: именительный – *nom*, родительный – *gen*, дательный – *dat*, винительный – *acc*, творительный – ins, предложный – *abl*. По умолчанию *nom*.

## Результат
После успешного выполнения возвращает список объектов [пользователей](https://vk.com/dev/objects/user) с дополнительным полем *found_with* для пользователей, найденных через импорт контактов. Для некоторых пользователей, которые были найдены давно поле *found_with* может отсутствовать.

## Исключения
+ В ходе выполнения могут произойти общие ошибки. Их описание находится на [отдельной странице](https://vk.com/dev/errors).

## Пример
``` csharp
var getSuggestions = _api.Friends.GetSuggestions();
```

## Версия Вконтакте API v.5.103
Дата обновления: 17.01.2020 16:53.