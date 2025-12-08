(function () {
    function getStored() {
        return localStorage.getItem('hct-theme');
    }

    function getPreferred() {
        if (window.matchMedia &&
            window.matchMedia('(prefers-color-scheme: dark)').matches) {
            return 'dark';
        }
        return 'light';
    }

    function getCurrent() {
        const stored = getStored();
        if (stored === 'light' || stored === 'dark') {
            return stored;
        }
        return getPreferred();
    }

    function applyTheme(theme) {
        // Put the theme on <html>
        if (theme !== 'light' && theme !== 'dark') return;
        document.documentElement.setAttribute('data-theme', theme);
    }

    function syncFromStorage() {
        const actual = getCurrent();
        const currentAttr = document.documentElement.getAttribute('data-theme');
        if (currentAttr !== actual) {
            applyTheme(actual);
        }
    }

    // Initial sync when script loads
    syncFromStorage();

    // 👇 This is the important part:
    // Keep re-applying the theme periodically so Blazor's
    // enhanced navigation can't "forget" it.
    setInterval(syncFromStorage, 500);

    window.hctTheme = {
        get: function () {
            return document.documentElement.getAttribute('data-theme') || getCurrent();
        },
        set: function (theme) {
            if (theme !== 'light' && theme !== 'dark') return;
            localStorage.setItem('hct-theme', theme);
            applyTheme(theme);
        },
        apply: function () {
            syncFromStorage();
            return getCurrent();
        }
    };
})();
