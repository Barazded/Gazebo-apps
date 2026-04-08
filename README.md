# Кроссплатформенный новостной агрегатор с конструктором API

---

## О проекте

**NewsAggregator (Gazebo Apps)** — это мобильное приложение для агрегации новостей, разработанное на платформе **Microsoft Xamarin** (позже перенесён на **.NET MAUI**). Проект поддерживает три основные операционные системы: **iOS**, **Android** и **UWP**.

Приложение позволяет пользователям получать актуальные новости из различных интернет-источников, сортировать их по категориям и дате, а также **добавлять собственные новостные сайты** через встроенный конструктор API — без участия разработчика.

---

## Возможности приложения

| Модуль | Описание |
| :--- | :--- |
| **Новостная лента** | Получение и отображение статей из выбранных источников. Поддерживаются фильтрация по разделам и сортировка по времени. |
| **Парсер (AngleSharp)** | Анализ веб-ресурсов|
| **Конструктор API** | Пользовательский интерфейс для добавления собственных источников: указание URL, CSS-селекторов для заголовков, изображений и текста, отладка и публикация. |
| **Сообщество** | Просмотр API, созданных другими пользователями, поиск, добавление источников в свою ленту. |
| **Личные настройки** | Управление списком ресурсов, хранение настроек отображения и авторизация. |

---

## Технологический стек

### Платформа разработки
- **Microsoft Xamarin.Forms** — кроссплатформенная разработка под iOS, Android, UWP на единой кодовой базе C#

### Backend
- **C# (.NET Standard)**
- **SQLite** — локальная СУБД для хранения пользовательских настроек
- **Firebase Realtime Database** — облачное хранение созданных пользователями API
- **Firebase Authentication**

### Парсинг веб-ресурсов
- **AngleSharp** — библиотека с открытым исходным кодом для анализа HTML и построения DOM-дерева

### Frontend
- **XAML** — язык разметки интерфейса
- **Figma** — проектирование UX/UI макетов до начала верстки

### Отладка
- **Xcode 14**

---

## Структура приложения

```mermaid
flowchart TD
    Start([Старт]) --> Auth{Авторизован}
    Auth -- Нет --> Enter[Вход/регистрация\nEnterPage]
    Auth -- Да --> Tabs[Навигация\nTabbedPage]
    Enter --> Tabs

    subgraph Pages[ ]
        direction TD
        subgraph TopRow[ ]
            direction LR
            News[Лента\nNewsPage]
            Community[Сообщество\nCommunityPage]
            Settings[Настройки\nSettingsPage]
        end
        Constructor[Конструктор\nConstructorPage]
    end

    Tabs <---> News
    Tabs <---> Community
    Tabs <---> Settings
    Community <---> Constructor

    subgraph DataLayer[ ]
        direction LR
        Firebase[(noSQL\nFirebase)]
        SQLite[(SQLite\nLocalSettings)]
    end

    Firebase -->|Get APIs| Community
    Constructor -->|Save API| Firebase
    Settings -->|Settings| SQLite
```

---
## Сравнение

| **Функция** | **Приложение аналог** |
| :--- | :--- |
| **Самостоятельное составление ленты** | "NewsWorm" |
| **Конструктор API (возможность добавлять свои интернет-ресурсы)** | — |
| **Новостная лента с фильтрами по разделам и сортировкой** | "Яндекс.Дзен", "Google.Новости", "РБК", "Pocket" |
| **Межпользовательское взаимодействие (возможность делиться любимыми ресурсами)** | "Pocket" |

---

## Интерфейс

#### Авторизация

| Вход | Создание аккаунта |
| :---: | :---: |
| <img width="250" src="https://github.com/user-attachments/assets/e501a9ae-5774-45fd-8a0a-46fc524838db" /> | <img width="250" src="https://github.com/user-attachments/assets/dfcfb979-fe7a-48fd-8949-b3e5d659989c" /> |

#### Основные экраны

| Лента новостей | Сообщество | Настройки |
| :---: | :---: | :---: |
| <img width="250" src="https://github.com/user-attachments/assets/73e3baa9-d783-4c92-87bb-6c18f4fef702" /> | <img width="250" src="https://github.com/user-attachments/assets/f61814df-d847-449d-9510-7c6a2f905f38" /> | <img width="250" src="https://github.com/user-attachments/assets/f30ff8a6-6866-459c-85a4-ebe201786f5c" /> |

#### Конструктор API

| Список ресурсов | Конструктор (сообщество) |
| :---: | :---: |
| <img width="250" src="https://github.com/user-attachments/assets/af81c1dc-19fe-4e5a-91a7-7a0e23aebe03" /> | <img width="250" src="https://github.com/user-attachments/assets/71f80e59-3391-43c9-be01-645e583f5b71" /> |


## Статус проекта

![Status](https://img.shields.io/badge/status-completed-blue)
![Platform](https://img.shields.io/badge/platform-iOS%20%7C%20Android%20%7C%20UWP-lightgrey)
![Xamarin](https://img.shields.io/badge/Xamarin-Forms-3498DB)
![MAUI](https://img.shields.io/badge/.NET-MAUI-512BD4)
![Year](https://img.shields.io/badge/Year-2024-orange)

**Проект завершён в 2024 году в рамках олимпиадной работы (Шаг в будущее).**


---
© 2024 Глущенко Дмитрий
